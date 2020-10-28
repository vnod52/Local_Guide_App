using System;
using UnityEngine;

public class RegionPanel : OpenClosePanel {
    public static RegionPanel Instance;
    
    public UIRegion prefRegion;
    public RectTransform regionContainer;

    protected override void Awake() {
        base.Awake();
        
        Instance = this;
    }

    public void Add(Region r) {
        UIRegion newRegion = Instantiate(prefRegion, regionContainer);
        newRegion.Intialize(r);
    }

    internal void Populate() {
        foreach (Region r in Initializer.Instance.country.regions) {
            Add(r);
        }
    }
}
