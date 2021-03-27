using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

    public GameObject NPC_object;
    public GameObject player;
    public string name;
    public string speech;
    public bool battler;
    public static bool stopped = false;
    public Text nameText;
    public Text speechText;
    public static bool spokenTo;

    void Update() {
        if (stopped) { //stops player moving animation and sets to idle
            player.GetComponent<Animator>().Rebind();
            player.GetComponent<Animator>().Play("Player_Idle");
            nameText.text = name;
            speechText.text = speech;
        }
    }

    void OnTriggerEnter2D(Collider2D c) {
        if (!spokenTo) {
            Debug.Log ("yessir");
            stopped = true;
            spokenTo = true;
        }
    }

}
