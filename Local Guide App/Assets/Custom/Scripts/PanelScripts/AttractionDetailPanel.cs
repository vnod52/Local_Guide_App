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
        ImagePosition();
    }

    //Load next attraction image on button click
    public void NextImage() {
        arrayIndex = (arrayIndex < attractionData.carouselImages.Length - 1) ? arrayIndex + 1 : 0;
        imgBackground.sprite = attractionData.carouselImages[arrayIndex];
        Debug.Log("Index: " + arrayIndex);

        for (int i = 0; i < attractionData.carouselImages.Length; i++) {
            if (arrayIndex == i) {
                imgPosContainer.transform.GetChild(arrayIndex).GetComponentInChildren<Image>().color = new Color(225.0F, 200.0F, 0.0F);
            } else {
                imgPosContainer.transform.GetChild(i).GetComponentInChildren<Image>().color = new Color(225.0F, 125.0F, 100.0F);
            }
        }
    }

    //Load previous attraction image on button click
    public void PreviousImage() {
        arrayIndex = (arrayIndex > 0) ?  arrayIndex - 1 : attractionData.carouselImages.Length - 1;
        imgBackground.sprite = attractionData.carouselImages[arrayIndex];
        Debug.Log("Index: " + arrayIndex);

        for (int i = 0; i < attractionData.carouselImages.Length; i++) {
            if (arrayIndex == i) {
                imgPosContainer.transform.GetChild(arrayIndex).GetComponentInChildren<Image>().color = new Color(225.0F, 200.0F, 0.0F);
            } else {
                imgPosContainer.transform.GetChild(i).GetComponentInChildren<Image>().color = new Color(225.0F, 125.0F, 100.0F);
            }
        }

    }

    //Create correct amount of images as per carousel array size
    public void ImagePosition() {
        int gallerySize = attractionData.carouselImages.Length;

        //Clean out child when you go back
        for (int i = imgPosContainer.transform.childCount - 1; i >= 0; i--) {
            Destroy(imgPosContainer.transform.GetChild(i).gameObject);
        }

        //Create required prefabs
        for (int i = 0; i < gallerySize; i++) {
            Instantiate(prefImgPos, imgPosContainer.transform);
        }
    }
}
