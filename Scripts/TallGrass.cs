using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallGrass : MonoBehaviour
{
    float rand;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D c) {
        time = 0f;
        Debug.Log ("In Grass!");
        rand = Random.Range(1, 10);
    }
    void OnTriggerStay2D(Collider2D c) {
        if (rand < time ) {
            Debug.Log ("BATTLE"); // switch to battle scene
        }
    }
    void OnTriggerExit2D(Collider2D c) {
        Debug.Log ("Off Grass!");
    }
}
