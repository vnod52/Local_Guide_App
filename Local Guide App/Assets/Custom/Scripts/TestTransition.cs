using UnityEngine;
using UnityEngine.EventSystems;

public class TestTransition : MonoBehaviour, IPointerClickHandler {
    public Transform transitionParent;
    public Animator anim;
    public bool isActiveByDefault;

    public void OnPointerClick(PointerEventData eventData) {
        Animator[] animators = transitionParent.GetComponentsInChildren<Animator>();
        foreach (Animator a in animators) {
            a.SetBool("IsActive", false);
        }

        anim.SetBool("IsActive", true);
    }

    private void Awake() {
        anim.SetBool("IsActive", isActiveByDefault);
    }
}
