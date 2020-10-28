﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIRegion : MonoBehaviour, IPointerClickHandler {
    public Text txtTitle;
    public Image imgBackground;
    public RectTransform regionParent;

    public Region region;

    public void OnPointerClick(PointerEventData eventData) {
        AttractionPanel.Instance.Open();
        AttractionPanel.Instance.Populate(region.attractions);
    }

    internal void Intialize(Region r) {
        region = r;
        txtTitle.text = region.regionName;
        imgBackground.sprite = region.regionImg;
    }
}
