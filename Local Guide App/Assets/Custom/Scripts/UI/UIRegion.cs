using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIRegion : MonoBehaviour, IPointerClickHandler {
    public Text txtTitle;
    public Image imgBackground;

    public Region region;

    public void OnPointerClick(PointerEventData eventData) {
        AttractionPanel.Instance.Open();
        AttractionPanel.PopulateAttractions(region.attractions);
    }

    
}
