using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bombs : MonoBehaviour
{

    public GameObject Clone;
    public int Cantidad;

    public void CloneObject()
    {
        int contador = 0;
        while (contador < Cantidad)
        {
            transform.position = new Vector3(-0.12f, 0.25f, 0.12f);
            Instantiate(Clone);
            contador++;
        }
    }
}
