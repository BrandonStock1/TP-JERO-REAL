using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colission : MonoBehaviour
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
        if (other.gameObject.name == "Blue car")
        {
            Destroy(gameObject);
            txtEliminado.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("Quedaron eliminados...");
        }
        if (other.gameObject.name == "Pista")
        {
            Debug.Log("Chocaste!");
        }
        if (other.gameObject.name == "Meta")
        {
            txtGanaste.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("Ganaste!!!");
        }
    }
}
