using UnityEngine;

public class Initializer : MonoBehaviour {
    public static Initializer Instance;

    public UIAttraction prefAttraction;

    public RegionPanel regionPanel;
    public Country country;
    public RectTransform rtAttraction;
    public RectTransform rtAttractionDesc;
     
    private void Awake() {
        Instance = this;

        regionPanel.Populate();
    }
}
