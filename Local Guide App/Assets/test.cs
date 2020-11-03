using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    ScrollRect scroll;
    // Start is called before the first frame update
    void Start()
    {
        scroll = GetComponent<ScrollRect>();
        scroll.verticalNormalizedPosition = 1;
        scroll.onValueChanged.AddListener(e => {
            Debug.Log(e);
        });
    }

}
