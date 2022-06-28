using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bombs : MonoBehaviour
{

    int CantCubos = 0;
    public GameObject Cube;

    public GameObject txtGanaste;
    public GameObject txtGanaste2;


    void Start()
    {
        
    }
    
    void Update()
    {
       
    }

    public void OnColissionEnter(Colission Col)
    {
        if (Col.gameObject.tag == "Auto" || Col.gameObject.tag == "Auto2")
        {
            txtGanaste.SetActive(true);
            gameObject.SetActive(false);
            while (CantCubos < 100)
            {
                Instantiate(Cube);
                CantCubos++;
            }
        }
    }
}
