using UnityEngine;

[CreateAssetMenu(fileName = "New Country", menuName = "Custom/Country")]
public class Country: ScriptableObject {
    public Region[] regions;

    internal void SpawnRegions(UIRegion _prefab, Transform _parent) {
        foreach (Region r in regions) {
            UIRegion newRegion = Instantiate(_prefab, _parent);
            newRegion.name = r.regionName;
        }
    }
}
