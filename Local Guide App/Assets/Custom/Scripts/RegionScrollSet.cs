using UnityEngine;
using UnityEngine.UI;

public class RegionScrollSet : MonoBehaviour {
    ScrollRect scroll;
    //Set ScrollRect to 1 so region starts from top
    void Start() {
        scroll = GetComponent<ScrollRect>();
        scroll.verticalNormalizedPosition = 1;
        //scroll.onValueChanged.AddListener(e => {
        //    Debug.Log(e);
        //});
    }

}
