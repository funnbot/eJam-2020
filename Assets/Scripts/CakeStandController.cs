using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CakeStandController : MonoBehaviour {
    Vector2 downPos;

    void Awake () {

    }

    public void OnPointerDown (PointerEventData eventData) {
        // if (!eventData.selectedObject.CompareTag("CakeStand")) return;
        SetAngularY(0);
    }

    public void OnDrag (PointerEventData eventData) {
        // if (!eventData.selectedObject.CompareTag("CakeStand")) return;
        if (MouseController.IsHolding()) return;
        var delt = eventData.delta;
        var dir = -delt.x;
        SetAngularY(dir);
    }

    void SetAngularY(float y) {
        transform.Rotate(Vector3.up * y);
    }

    Vector3 MouseToWorld () {
        RaycastHit hit;
        Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 10f);
        return hit.point;
    }
}