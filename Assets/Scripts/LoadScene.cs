using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public int id;
    void Start() {
        SceneManager.LoadScene(id);
    }
}