using UnityEngine;

public class ButtonNavigate : MonoBehaviour {
    public Animator animator;

    //Open a panel, run open animation
    public void Open() {
        animator.SetBool("open", true);
    }

    //Close a panel, run close animation
    public void Close() {
        animator.SetBool("open", false);
    }

    //Open attraction addresss in google maps
    public void OpenMaps() {
        Application.OpenURL(AttractionDetailPanel.Instance.txtAddress);
    }  
    
    //Share attraction to friends
    public void Share() {
        //Application.OpenURL("https://goo.gl/maps/7WX6xbmtQMX7kox27");
    }
}
