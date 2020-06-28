using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CakeStandController : MonoBehaviour {
    public float rotSpeed;

    void Awake () {

    }

    public void OnPointerDown (PointerEventData eventData) {
        // if (!eventData.selectedObject.CompareTag("CakeStand")) return;
    }

    public void OnDrag (PointerEventData eventData) {
        // if (!eventData.selectedObject.CompareTag("CakeStand")) return;
        if (MouseController.IsHolding()) return;
        var delt = eventData.delta;
        var dir = -delt.x;
        Rotate(dir);
    }

    void Rotate(float y) {
        transform.Rotate(Vector3.up * y * rotSpeed);
    }

    Vector3 MouseToWorld () {
        RaycastHit hit;
        Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 10f);
        return hit.point;
    }
}