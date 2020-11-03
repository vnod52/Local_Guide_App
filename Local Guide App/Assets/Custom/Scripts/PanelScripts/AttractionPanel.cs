using UnityEngine;

public class AttractionPanel : OpenClosePanel {
    //Create instance of attraction panel
    public static AttractionPanel Instance;
    
    public UIAttraction prefAttraction;
    public RectTransform attractionContainer;

    protected override void Awake() {
        base.Awake();
        Instance = this;
    }

    //Create attraction prefabs when region is clicked
    public void Add(Region.Attraction a) {
        UIAttraction newAttraction = Instantiate(prefAttraction, attractionContainer);
        newAttraction.Initialize(a); 
    }

    public void Populate(Region.Attraction[] attractions) {
        //Clean out child when you go back
        for (int i = attractionContainer.childCount - 1; i >= 0; i--) {
            Destroy(attractionContainer.transform.GetChild(i).gameObject);
        }

        //Add attractions to list
        foreach (Region.Attraction a in attractions) {
            Add(a);
        }
    }
}
