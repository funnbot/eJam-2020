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

    public static void GoToOrder() {

    }

    public static void GoToBuild() {

    }

    public static void GoToJudge() {
        Inst.cakeDecors = CakeController.Inst.CompileDecorations();
        SceneManager.LoadScene(0);
    }

    public static CrossSceneOrder Inst;
    void Awake() {
        if (Inst != null) throw new System.Exception("Duplicate instance of singleton CrossSceneOrder");
        Inst = this;
        
        DontDestroyOnLoad(this);
    }
}