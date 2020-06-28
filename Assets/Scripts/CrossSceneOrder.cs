using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossSceneOrder : MonoBehaviour {
    public Customer customer;

    public CustomersSO customers;
    public CakesSO cakes;
    public DecorationsSO decorations;
    public FrostingsSO frostings;

    public List<Decoration> cakeDecors;

    public void GoToOrder() {
        SceneManager.LoadScene(1);
    }

    public void GoToBuild () {
        SceneManager.LoadScene (2);
    }

    public void GoToJudge () {
        Inst.cakeDecors = CakeController.Inst.CompileDecorations ();
        SceneManager.LoadScene (3);
    }

    public static CrossSceneOrder Inst;
    void Awake () {
        if (Inst != null) Destroy(gameObject);
        Inst = this;

        DontDestroyOnLoad (this);
    }
}