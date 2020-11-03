using UnityEngine;
using UnityEngine.UI;

public class AttractionDetailPanel : OpenClosePanel {
    //Create instance of attraction detail panel
    public static AttractionDetailPanel Instance;

    public Image imgBackground;
    public Text txtAttractionTitle;
    public Text txtAttractionDescription;
   
    protected override void Awake() {
        base.Awake();
        Instance = this;
    }

    //Populate the details info passed down from attractions.
    public void Populate(Region.Attraction attraction) {
        imgBackground.sprite = attraction.attractionImg;
        txtAttractionTitle.text = attraction.fullText.name;
        txtAttractionDescription.text = attraction.fullText.text;
        Debug.Log(transform.Find("DescriptionTitle").GetComponent<Text>());
        GameObject.Find("Description");

    }
}
