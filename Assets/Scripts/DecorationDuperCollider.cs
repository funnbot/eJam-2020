using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DecorationDuperCollider : MonoBehaviour, IPointerDownHandler {
    DecorationDuper parent;
    void Awake () {
        parent = transform.GetComponentInParent<DecorationDuper> ();
    }

    public void OnPointerDown (PointerEventData eventData) {
        parent.OnPointerDown(eventData);
    }
}