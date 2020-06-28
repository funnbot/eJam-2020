using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseController : MonoBehaviour {
    public GameObject cake;
    public float rotSpeed;

    private GameObject selected;

    void Update () {
        if (IsHolding ()) {
            RaycastHit hit;
            if (MouseToWorldPos (out hit)) {
                selected.transform.position = hit.point;

                if (Input.GetMouseButtonUp (0) && hit.transform.CompareTag ("Cake")) {
                    var cake = hit.transform.GetComponent<CakeController>();
                    cake.AddDecoration(selected);
                    selected.transform.parent = cake.transform;
                    selected = null;
                }
            }

            if (Input.GetKey (KeyCode.A)) {
                selected.transform.Rotate (Vector3.up * rotSpeed);
            }
            if (Input.GetKey (KeyCode.D)) {
                selected.transform.Rotate (Vector3.down * rotSpeed);
            }
        }
    }

    public static void Hold (GameObject duped) {
        Inst.selected = duped;
    }

    public static bool IsHolding () {
        return Inst.selected != null;
    }

    public static bool MouseToWorldPos (out RaycastHit hit) {
        var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        return Physics.Raycast (ray, out hit, 10f, LayerMask.GetMask("MouseControllerRaycast"));
    }

    public static MouseController Inst;
    void Awake () {
        if (Inst != null) throw new System.Exception ("Duplicate instance of singleton MouseController");
        Inst = this;
    }
}