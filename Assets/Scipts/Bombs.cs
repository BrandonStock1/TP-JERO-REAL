using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bombs : MonoBehaviour
{

    public GameObject Clone;
    public int Cantidad;
    public Text txtCantClon;

    public void CloneObject()
    {
        Cantidad = int.Parse(txtCantClon.text);
        int contador = 0;
        while (contador < Cantidad)
        {
            Instantiate(Clone);
            contador++;
        }
    }
}
