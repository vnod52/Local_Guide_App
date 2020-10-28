using UnityEngine;

public class RegionPanel : OpenClosePanel {
    public static RegionPanel Instance;
    
    public UIRegion prefRegion;
    public RectTransform regionContainer;

    protected override void Awake() {
        base.Awake();
        
        Instance = this;
    }

    public void AddRegion(Region r) {
        UIRegion newRegion = Instantiate(prefRegion, regionContainer);
        newRegion.txtTitle.text = r.regionName;
        newRegion.imgBackground.sprite = r.regionImg;
        newRegion.region = r;
    }
}
