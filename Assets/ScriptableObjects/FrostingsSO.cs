using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FrostingColor {
    White,
    Black,
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Violet
}

[System.Serializable]
public struct Frosting {
    public FrostingColor color;
    public Material material;
}

[CreateAssetMenu (fileName = "Frostings")]
public class FrostingsSO : ScriptableObject {
    public Frosting[] frostings;

    public Frosting GetFrosting(FrostingColor color) {
        foreach (var f in frostings) if (f.color == color) return f;
        return frostings[0];
    }
}