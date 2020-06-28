using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JudgeText : MonoBehaviour {
    void Start() {
        int req = 0, dis = 0;
        
        var decors = CrossSceneOrder.Inst.cakeDecors;
        var fave = CrossSceneOrder.Inst.customer.decorationCat;

        foreach (var d in decors) {
            if (d.cat == fave) req++;
            else dis++;
        }

        var judge = GetComponent<TMP_Text>();

        judge.text = System.String.Format("Requested Toppings: {0} (+{1})\nDisliked Toppings: {2} (-{3})\n<b>Total Score:</b> {4}", req, req * 100, dis, dis * 50, req * 100 - dis * 50);
    }
}