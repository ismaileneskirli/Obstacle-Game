using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer renderer;  // Caching a reference

    Rigidbody rigidBody;

    [SerializeField] float  TimeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        // When the game starts go get the mesh renderer and disable it, also disable the gravity.
        renderer.enabled = false;
        rigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeToWait ){
            //Debug.Log("3 sec already passsed");
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
