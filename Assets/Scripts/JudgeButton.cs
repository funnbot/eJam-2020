using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JudgeButton : MonoBehaviour, IPointerDownHandler {
    public void OnPointerDown(PointerEventData eventData) {
        CrossSceneOrder.Inst.GoToOrder();
    }
}