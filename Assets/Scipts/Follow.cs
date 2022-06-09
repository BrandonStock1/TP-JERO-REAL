using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Follow : MonoBehaviour
{

    public float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timeElapsed += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Libero la tecla");
            timeElapsed = 0;
        }

        Debug.Log(Mathf.Floor(timeElapsed));
    }
}
