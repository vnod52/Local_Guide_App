
using UnityEngine;

public class GeneratePrefabs : MonoBehaviour {
    public UIAttraction prefab;
    public GameObject parentObject;
     
    private void Awake() {
        for (int  x = 0;  x < 6;  x++) {
            UIAttraction newAttraction = Instantiate(prefab, parentObject.transform);
        }
    }
}
