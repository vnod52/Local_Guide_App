using UnityEngine;

public class OpenClosePanel : MonoBehaviour {
    public GameObject Panel;

    public void OpenPanel() {
        if (Panel != null) {
            Animator animator = Panel.GetComponent<Animator>();
            Panel.SetActive(true);
            if (animator != null) {
                animator.SetBool("open", true);
                
            
            }
        }
    }
    
    public void ClosePanel() {
        if (Panel != null) {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null) {
                animator.SetBool("open", false);
            }
        }
    }
}
