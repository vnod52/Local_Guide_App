using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIAttraction : MonoBehaviour, IPointerClickHandler {
    public Text txtTitle;
    public Image imgBackground;

    public Region.Attraction attraction;

    //Open attraction detail panel and populate info based on attraction selected
    public void OnPointerClick(PointerEventData eventData) {
        AttractionDetailPanel.Instance.Open();
        AttractionDetailPanel.Instance.Populate(attraction);
    }

    //Give each attraction a name and bg image
    public void Initialize(Region.Attraction a) {
        attraction = a;
        txtTitle.text = attraction.fullText.name;
        imgBackground.sprite = attraction.attractionImg;
    }
}
