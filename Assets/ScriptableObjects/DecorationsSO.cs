using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DecorationCat {
    Frosting,
    Sprinkles,
    Candy,
    Fruit,
    Candle
}

[System.Serializable]
public struct Decoration {
    public string name;
    [SerializeField]
    public GameObject model;
    public DecorationCat cat;
}

[CreateAssetMenu (fileName = "Decorations")]
public class DecorationsSO : ScriptableObject {
    public Decoration[] decorations;

    public Decoration GetDecor(string name) {
        foreach (var d in decorations) if (d.name == name) return d;
        return decorations[0];
    }
}