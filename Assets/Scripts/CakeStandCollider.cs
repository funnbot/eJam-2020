using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CakeStandCollider : MonoBehaviour, IPointerDownHandler, IDragHandler {
    CakeStandController parent;

    void Awake () {
        parent = transform.GetComponentInParent<CakeStandController> ();
    }

    public void OnDrag (PointerEventData eventData) {
        parent.OnDrag (eventData);
    }

    public void OnPointerDown (PointerEventData eventData) {
        parent.OnPointerDown (eventData);
    }
}