using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour
{

    public GameObject txtEliminado;

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
            txtEliminado.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("Quedaste eliminado...");
        }
        if (other.gameObject.name == "Pista")
        {
            Debug.Log("Chocaste!");
        }
    }
}
