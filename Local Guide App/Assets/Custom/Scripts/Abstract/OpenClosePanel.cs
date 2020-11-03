using UnityEngine;

public abstract class OpenClosePanel : MonoBehaviour {
    protected Animator animator;

    protected virtual void Awake() {
        animator = GetComponent<Animator>();
    }

    //Open panels 
    public void Open() {
        animator.SetBool("open", true);
    }
    
    //close panels
    public void Close() {
        animator.SetBool("open", false);
    }
}
