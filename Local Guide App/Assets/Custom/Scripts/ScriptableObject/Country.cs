using UnityEngine;

//Custom menu item to create a new country with region array.
[CreateAssetMenu(fileName = "New Country", menuName = "Custom/Country")]
public class Country: ScriptableObject {
    public Region[] regions;
}
