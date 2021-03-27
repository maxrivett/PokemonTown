using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

     public float moveSpeed = 5f;

     public Rigidbody2D rb;
     public Animator animator;

     Vector2 movement;
  
    // Update is called once per frame
    void Update() {
        if (!NPC.stopped) {
            //Input
            movement.x = Input.GetAxisRaw("Horizontal"); //will return -1 for left and 1 for right
            movement.y = Input.GetAxisRaw("Vertical"); //will return -1 for up and 1 for down

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        } else {

        }
    }

    void FixedUpdate() { 
        if (!NPC.stopped) {
            //Movement
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }


}
