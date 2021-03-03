using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float yValue = 0.00f;
    [SerializeField] float moveSpeed = 5.00f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction(){
        Debug.Log("Welcome to the game");

    }

    void MovePlayer(){
        // Time.deltaTime makes it frame rate independant
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed ;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed ;

        transform.Translate(xValue,yValue,zValue);
    }
}
