using UnityEngine;
using UnityEngine.UI;

public class AttractionDetailPanel : OpenClosePanel {
    //Create instance of attraction detail panel
    public static AttractionDetailPanel Instance;

    public Image imgBackground;
    public Text txtAttractionTitle;
    public Text txtAttractionDescription;
    public string txtAddress;
    public GameObject imgPosContainer;
    public Image prefImgPos;
    public Sprite fill;
    public Sprite noFill;

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
        CreateImgPosPref();

    }

    //Load next attraction image on button click
    public void NextImage() {
        arrayIndex = (arrayIndex < attractionData.carouselImages.Length - 1) ? arrayIndex + 1 : 0;
        imgBackground.sprite = attractionData.carouselImages[arrayIndex];

        ShowImgPos();
    }

    //Load previous attraction image on button click
    public void PreviousImage() {
        arrayIndex = (arrayIndex > 0) ?  arrayIndex - 1 : attractionData.carouselImages.Length - 1;
        imgBackground.sprite = attractionData.carouselImages[arrayIndex];

        ShowImgPos();
    }

    //Create correct amount of images as per carousel array size
    public void CreateImgPosPref() {
        int gallerySize = attractionData.carouselImages.Length;

        //Clean out child when you go back
        for (int i = imgPosContainer.transform.childCount - 1; i >= 0; i--) {
            Destroy(imgPosContainer.transform.GetChild(i).gameObject);
        }

        //Create required prefabs
        for (int i = 0; i < gallerySize; i++) {
            Image img = Instantiate(prefImgPos, imgPosContainer.transform);
            if (i == 0) img.sprite = fill;
        }
        Debug.Log("aaa");
    }

    //Show image position as your scroll back and forth in image carousel 
    public void ShowImgPos() {
        //Show image postion as you move back
        for (int i = 0; i < attractionData.carouselImages.Length; i++) {
            if (arrayIndex == i) {
                imgPosContainer.transform.GetChild(arrayIndex).GetComponentInChildren<Image>().sprite = fill;
            } else {
                imgPosContainer.transform.GetChild(i).GetComponentInChildren<Image>().sprite = noFill;
            }
        }
    }
}
