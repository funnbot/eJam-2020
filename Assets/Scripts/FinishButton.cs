using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FinishButton : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick (PointerEventData eventData) {
        CrossSceneOrder.Inst.GoToJudge();
    }
}