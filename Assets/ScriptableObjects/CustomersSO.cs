using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Species {
    Dog,
    Cat,
}

public enum Breed {
    // Dog
    ShibaInu,
    GermanShephard,
}

[System.Serializable]
public struct Customer {
    public Species species;
    public Breed breed;
    public CakeType cakeType;
    public CakeFlavor cakeFlavor;
    public FrostingColor frostingColor;
    public DecorationCat decorationCat;
}

[CreateAssetMenu (fileName = "Customers")]
public class CustomersSO : ScriptableObject {
    public Customer[] customers;
}