using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        // What do you want to happen when collision happened ?
        // Other parameter is who collided with me.
        //Debug.Log("Collision happened ! Be careful !");
        // Aceessing the mesh renderer of the object that this script is attached to, then changing the color of it.
        if(other.gameObject.tag == "Player" )
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            // if i dont use other it means the script attached to
            gameObject.tag = "Hit";
        }


    }

}

