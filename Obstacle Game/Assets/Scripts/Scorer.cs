using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int counter = 0;
    private void OnCollisionEnter(Collision other)
    {
        // What do you want to happen when collision happened ?
        // Other parameter is who collided with me.
        if( other.gameObject.tag != "Hit"){
            counter ++;
             Debug.Log("You've bumped into a thing this many times:" + counter);
        // Aceessing the mesh renderer of the object that this script is attached to, then changing the color of it.

        }


    }
}

