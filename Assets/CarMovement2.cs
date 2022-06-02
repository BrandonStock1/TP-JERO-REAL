using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement2 : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed;
        movementSpeed = 1;
        float rotationSpeed;
        rotationSpeed = 1;

        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
    }
}
