using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {

    public GameObject player;
    public GameObject sidebar;
    public GameObject dialogueBox;


    public bool sidebarActive;
    bool dialogueBoxActive;


    // Start is called before the first frame update
    void Start() {
        sidebar.SetActive(false);
        
    }

    // Update is called once per frame
    void Update() {
        if (NPC.stopped) {
            
            dialogueBox.SetActive(true);
            dialogueBoxActive = true;
        }
        if (dialogueBoxActive && Input.GetKeyUp(KeyCode.A)) {
            dialogueBox.SetActive(false);
            dialogueBoxActive = false;
            NPC.stopped = false;
        }

        if(Input.GetKeyUp(KeyCode.Space) && !NPC.stopped) {
            if (!sidebarActive) {
                showSidebar();
            } else {
                hideSidebar();
            }
        }
    }

    public void showSidebar() {
        sidebar.SetActive(true);
        sidebarActive = true;
    }
    public void hideSidebar() {
        sidebar.SetActive(false);
        sidebarActive = false;
    }
    public void showDialogue() {

    }
    public void hideDialogue() {
        
    }

}

