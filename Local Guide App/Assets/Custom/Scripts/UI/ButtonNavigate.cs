using UnityEngine;

public class ButtonNavigate : MonoBehaviour {
    public Animator animator;

    public void Open() {
        animator.SetBool("open", true);
    }

    public void Close() {
        animator.SetBool("open", false);
    }

}
