using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidebar : MonoBehaviour
{
    public GameObject pokemonButton; //new scene/canvas showing pokemon
    public GameObject bagButton; //new scene showing items, tms, etc
    public GameObject settingsButton; //new canvas with settings
    public GameObject saveButton; //save the game (to txt file?)
    public GameObject quitButton; //quit app

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitGame() { //for quitButton onClick()
        Debug.Log ("QUIT");
        Application.Quit(); 
    }

}
