using UnityEngine;
using UnityEngine.UI;

public class AttractionDetailPanel : OpenClosePanel {
    public static AttractionDetailPanel Instance;

    public Image img;
    public Text txt;

    protected override void Awake() {
        base.Awake();
        Instance = this;
    }
}
