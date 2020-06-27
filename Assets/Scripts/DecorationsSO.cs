using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Decorations")]
public class DecorationsSO : ScriptableObject {
    [System.Serializable]
    public struct Decoration {
        [SerializeField]
        GameObject model;
    }
    public Decoration[] decorations;
}