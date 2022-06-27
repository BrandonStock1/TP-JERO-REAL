using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission2 : MonoBehaviour
{

    public GameObject txtEliminado;
    public GameObject txtGanaste;

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
        if (other.gameObject.name == "Yellow Car")
        {
            Destroy(gameObject);
            txtEliminado.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("Quedaron eliminados...");
        }
        if (other.gameObject.name == "Meta")
        {
            txtGanaste.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("Ganaste!!!");
        }
    }
 
}