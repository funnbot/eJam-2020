using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OrderButton : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick (PointerEventData eventData) {
        CrossSceneOrder.Inst.GoToBuild();
    }
}