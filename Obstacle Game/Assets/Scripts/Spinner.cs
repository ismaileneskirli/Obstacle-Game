using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 1;
    [SerializeField] float zAngle = 0;
     // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the thing that this script is attached to.
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
