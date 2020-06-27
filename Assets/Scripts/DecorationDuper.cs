using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DecorationDuper : MonoBehaviour {
    [SerializeField]
    private GameObject prefab;

    public void OnPointerDown (PointerEventData eventData) {
        if (MouseController.IsHolding()) return;
        var duped = Instantiate(prefab, transform.position, transform.rotation, null);
        MouseController.Hold(duped);
    }
}