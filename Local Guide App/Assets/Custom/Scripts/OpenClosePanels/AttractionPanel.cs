using System;
using UnityEngine;

public class AttractionPanel : OpenClosePanel {
    public static AttractionPanel Instance;
    
    public UIAttraction prefAttraction;
    public RectTransform attractionContainer;

    protected override void Awake() {
        base.Awake();
        Instance = this;
    }

    public void AddAttraction(Region.Attraction a) {
        UIAttraction newAttraction = Instantiate(prefAttraction, attractionContainer);
        newAttraction.txtTitle.text = a.fullText.name;
        newAttraction.imgBackground.sprite = a.attractionImg;
        newAttraction.attraction = a;
    }

    internal static void PopulateAttractions(Region.Attraction[] attractions) {
        foreach (var item in collection) {

        }
        
    }
}
