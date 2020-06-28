using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeController : MonoBehaviour {
    public GameObject decorHolder;

    void Start () {
        var c = CrossSceneOrder.Inst.customer;
        var cakeInfo = CrossSceneOrder.Inst.cakes.GetCake (c.cakeType);
        var frosting = CrossSceneOrder.Inst.frostings.GetFrosting (c.frostingColor);
        LoadCake (cakeInfo, frosting);
    }

    public void LoadCake (Cake cakeInfo, Frosting frosting) {
        var obj = Instantiate (cakeInfo.model, Vector3.zero, Quaternion.identity);
        obj.transform.SetParent (transform, false);
        obj.GetComponentInChildren<MeshRenderer> ().sharedMaterial = frosting.material;
    }

    public void AddDecoration (GameObject dupe) {
        dupe.transform.parent = decorHolder.transform;
    }

    public List<Decoration> CompileDecorations () {
        var decorations = new List<Decoration> ();
        Transform child;
        while (child = transform.GetChild (0)) {
            var cont = child.GetComponent<DecorationController> ();
            decorations.Add (cont.type);
        }
        return decorations;
    }

    public static CakeController Inst;
    void Awake () {
        if (Inst != null) throw new System.Exception ("Duplicate instance of singleton CakeController");
        Inst = this;
    }
}