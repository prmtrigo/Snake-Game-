using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    //due to trigger and boxgrid, food can't spawn on the walls

    public BoxCollider2D gridArea;

    private void Start(){

        RandomizePosition();
    }
    //now, we have to randomize the food position!!

    private void RandomizePosition(){

        Bounds bounds =  this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);

    }

    //When Trigger is Activated, Food goes to another Random Position!

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Player"){
        RandomizePosition();
        }

    }
}

