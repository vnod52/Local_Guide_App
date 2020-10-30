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

    //Create the region prefab for each region
    public void Add(Region r) {
        UIRegion newRegion = Instantiate(prefRegion, regionContainer);
        newRegion.Intialize(r);
    }

    //Populate region info
    internal void Populate() {
        foreach (Region r in Initializer.Instance.country.regions) {
            Add(r);
        }
    }
}
