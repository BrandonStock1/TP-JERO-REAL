using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bombs : MonoBehaviour
{

    public GameObject Clone;
    public int Cantidad;
    //public Text txtCantClon;

    public void CloneObject()
    {
        //Cantidad = int.Parse(txtCantClon.text);
        int contador = 0;
        while (contador < Cantidad)
        {
            transform.position = new Vector3(-0.12f, 0.25f, 0.12f);
            Instantiate(Clone);
            contador++;
        }
    }
}
