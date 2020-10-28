using UnityEngine;

public class OpenClosePanel : MonoBehaviour {
    private Animator animator;

    protected virtual void Awake() {
        animator = GetComponent<Animator>();
    }

    public void Open() {
        gameObject.SetActive(true);
        animator.SetBool("open", true);
    }
    
    public void Close() {
        animator.SetBool("open", false);
    }
}
