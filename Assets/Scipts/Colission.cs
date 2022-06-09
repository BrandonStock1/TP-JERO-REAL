using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colission : MonoBehaviour
{

    public Text txtEliminado;
    public Text txtGanaste; 


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
            txtEliminado.text = "Quedaste eliminado debido a un choque!!!";
            Time.timeScale = 0;
            Debug.Log("Quedaste eliminado...");
        }
        if (other.gameObject.name == "Pista")
        {
            txtEliminado.text = "Quedaste eliminado debido a un choque!!!";
            Debug.Log("Chocaste!");
        }
        if (other.gameObject.name == "Meta")
        {
            txtGanaste.text = "Ganaste!!!";
            Time.timeScale = 0;
            Debug.Log("Quedaste eliminado...");
        }
    }
}
