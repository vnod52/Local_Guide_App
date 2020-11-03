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

}
