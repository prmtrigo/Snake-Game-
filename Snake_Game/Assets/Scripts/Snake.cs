using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    //declaring a variable
    private Vector2 direction = Vector2.right;

    private void Update(){

    //Let's Create Our Inputs!

        if (Input.GetKeyDown(KeyCode.W)){
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D)){
            direction = Vector2.right;
        }
    }
    private void FixedUpdate(){
        
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x )+  direction.x,
            Mathf.Round(this.transform.position.y )+  direction.y,
            0.0f
        );

    }
}

