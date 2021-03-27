using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    public int sceneToChangeTo;
    bool nextScene = false;

    void Update() {
        if (nextScene) {
            SceneManager.LoadScene(sceneToChangeTo);
            nextScene = false;
        }
    }

    void OnTriggerEnter2D(Collider2D c) {
        Debug.Log ("Hit Door");
        nextScene = true;
    }
}

