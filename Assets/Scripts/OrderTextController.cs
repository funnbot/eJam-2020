using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OrderTextController : MonoBehaviour {
    TMP_Text order;

    static string[] names = {
        "Tank",
        "Rita",
        "Pino",
        "Parakeet",
        "Poe",
        "Zelda",
        "Hilda",
        "Indie",
        "Rina",
        "Spot",
        "Cleo",
        "Libby",
        "Ginger",
        "Ghost",
        "River",
        "Pariah",
        "Meatball",
        "Socks",
        "Beatrice",
        "Maxwell",
        "Snuffles",
        "Fluffy",
        "Misty"
    };

    void Start () {
        order = GetComponent<TMP_Text> ();

        var name = names[Random.Range(0, names.Length)];
        var customer = CrossSceneOrder.Inst.customers.customers[Random.Range(0, CrossSceneOrder.Inst.customers.customers.Length)];

        order.text = System.String.Format ("<b>New Order</b>\n For: {0}, a {1}\nCake: {2} {3}\nFavorite Toppings: {4}", name, 
            customer.breed.ToString(), customer.cakeFlavor.ToString(), customer.cakeType.ToString(), customer.decorationCat.ToString());

        CrossSceneOrder.Inst.customer = customer;
    }
}