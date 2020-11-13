using UnityEngine;
using UnityEngine.UI;

public class AttractionDetailPanel : OpenClosePanel {
    //Create instance of attraction detail panel
    public static AttractionDetailPanel Instance;

    public Image imgBackground;
    public Text txtAttractionTitle;
    public Text txtAttractionDescription;
    public string txtAddress;

    private Region.Attraction attractionData;
    private int arrayIndex = 0;

    protected override void Awake() {
        base.Awake();
        Instance = this;
    }

    //Populate the details info passed down from attractions.
    public void Populate(Region.Attraction attraction) {
        txtAttractionTitle.text = attraction.fullText.name;
        txtAttractionDescription.text = attraction.fullText.text;
        txtAddress = attraction.address;
        arrayIndex = 0;
        imgBackground.sprite = attraction.carouselImages[arrayIndex];
        attractionData = attraction;
    }

    //Load next attraction image on button click
    public void NextImage() {
        arrayIndex = (arrayIndex < attractionData.carouselImages.Length - 1) ? arrayIndex + 1 : 0;
        imgBackground.sprite = attractionData.carouselImages[arrayIndex];
    }

    //Load previous attraction image on button click
    public void PreviousImage() {
        arrayIndex = (arrayIndex > 0) ?  arrayIndex - 1 : attractionData.carouselImages.Length - 1;
        imgBackground.sprite = attractionData.carouselImages[arrayIndex];
    }
}
