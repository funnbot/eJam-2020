using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CakeType {
    SingleLayer,
    DoubleLayer,
    TripleLayer,
    Bundt,
    CupCake,
    UpsideDown,
    Sponge
}

public enum CakeFlavor {
    Vanilla,
    Chocolate,
    Strawberry,
    Confetti,
    IceCream,
    RedVelvet
}

[System.Serializable]
public struct Cake {
    [SerializeField]
    public GameObject model;
    public CakeType type;
}

[CreateAssetMenu (fileName = "Cakes")]
public class CakesSO : ScriptableObject {
    public Cake[] cakes;

    public Cake GetCake(CakeType type) {
        foreach (var cake in cakes) if (cake.type == type) return cake;
        return cakes[0];
    }
}