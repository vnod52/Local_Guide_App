using UnityEngine;
using System.IO;
using System.Collections;

public class ButtonNavigate : MonoBehaviour {
    public Animator animator;

    private string shareMessage;

    //Open a panel, run open animation
    public void Open() {
        animator.SetBool("open", true);
    }

    //Close a panel, run close animation
    public void Close() {
        animator.SetBool("open", false);
    }

    //Close the application
    public void ExitApp() {
        Application.Quit();
    }

    //Open attraction addresss in google maps
    public void OpenMaps() {
        Application.OpenURL(AttractionDetailPanel.Instance.txtAddress);
    }

    //Share attraction to friends
    public void Share() {
        shareMessage = "Check this out! " + AttractionDetailPanel.Instance.txtAddress;
        StartCoroutine(TakeScreenshotAndShare());
    }

    //Native share method displays message and screenshot of app;
    private IEnumerator TakeScreenshotAndShare() {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
        File.WriteAllBytes(filePath, ss.EncodeToPNG());

        // To avoid memory leaks
        Destroy(ss);

        new NativeShare().AddFile(filePath)
            .SetSubject("NZ Local Guide").SetText(shareMessage)
            .SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
            .Share();
    }

}
