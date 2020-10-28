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

    public void Add(Region.Attraction a) {
        UIAttraction newAttraction = Instantiate(prefAttraction, attractionContainer);
        newAttraction.Initialize(a);
    }

    public void Populate(Region.Attraction[] attractions) {
        //Clean out child when you go back
        for (int i = attractionContainer.childCount - 1; i >= 0; i--) {
            Destroy(transform.GetChild(i).gameObject);
        }

        Debug.Log("no of attractions " + attractions.Length);

        //Add attractions to list
        foreach (Region.Attraction a in attractions) {
            Debug.Log(a.fullText.name);
            Add(a);
        }
    }
}
