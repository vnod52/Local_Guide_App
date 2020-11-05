using System;
using UnityEngine;

[Serializable]
public class Region {
    [Serializable]
    public class Attraction {
        //Every attraction has an image array, attraction name, address and description(in text file)
        public Sprite attractionImg;
        public Sprite[] carouselImages;
        public TextAsset fullText;
        public string address;
    }

    //Every region has an array of attraction
    public string regionName;
    public Sprite regionImg;
    public Attraction[] attractions;
}