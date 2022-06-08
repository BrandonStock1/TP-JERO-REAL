using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Red car")
        {
            Destroy(gameObject);
        }
    }
}
