using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bombs : MonoBehaviour
{

    public GameObject Clone;
    public int Cantidad;

    public GameObject txtGanaste;
    public GameObject txtGanaste2;


    void Start()
    {
        
    }
    
    void Update()
    {
        if (txtGanaste == false)
        {
            CloneObject();
        }
        if (txtGanaste2 == false)
        {
            CloneObject();
        }
    }

    public void CloneObject()
    {
        int contador = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            while (contador < Cantidad)
            {
                Instantiate(Clone);
                contador++;
            }
        }
    }
}
