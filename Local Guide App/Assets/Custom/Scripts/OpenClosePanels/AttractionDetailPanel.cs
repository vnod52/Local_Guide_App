using UnityEngine;
using UnityEngine.UI;

public class AttractionDetailPanel : OpenClosePanel {
    public static AttractionDetailPanel Instance;

    public Image imgBackground;
    public Text txtAttractionTitle;
    public Text txtAttractionDescription;
   
    protected override void Awake() {
        base.Awake();
        Instance = this;
    }

    public void Populate(Region.Attraction attraction) {
        imgBackground.sprite = attraction.attractionImg;
        txtAttractionTitle.text = attraction.fullText.name;
        txtAttractionDescription.text = attraction.fullText.text;

    }
}
