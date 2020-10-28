using UnityEngine;

[CreateAssetMenu(fileName = "New Country", menuName = "Custom/Country")]
public class Country: ScriptableObject {
    public Region[] regions;
}
