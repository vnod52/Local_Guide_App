using System;
using UnityEngine;

[Serializable]
public class Region {
    [Serializable]
    public class Attraction {
        public Sprite attractionImg;
        public Sprite[] carouselImages;
        public TextAsset fullText;
    }

    public string regionName;
    public Sprite regionImg;
    public Attraction[] attractions;
}