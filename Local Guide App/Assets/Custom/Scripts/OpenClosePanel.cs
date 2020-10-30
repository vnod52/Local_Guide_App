using UnityEngine;

public class OpenClosePanel : MonoBehaviour {
    public Animator animator;

    protected virtual void Awake() {
        animator = GetComponent<Animator>();
    }

    //Open panels 
    public void Open() {
        gameObject.SetActive(true);
        animator.SetBool("open", true);
    }
    
    //close panels
    public void Close() {
        animator.SetBool("open", false);
    }
}
