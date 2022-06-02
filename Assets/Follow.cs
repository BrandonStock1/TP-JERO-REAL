using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Follow : MonoBehaviour
{
    public Text txt_time;
    public Text txt_timeFloored;
    public Text txt_min;
    public Text txt_seg;


    public float elapsedTime;
    public bool isCounting;


    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isCounting = false;
    }

    // Update is called once per frame
    void Update()
    {

        float CurrentTime = Time.time;

        txt_time.text = CurrentTime.ToString();
        
        txt_timeFloored = Mathf.Floor(CurrentTime).ToString();
        
        //contador 
        txt_min.text = Mathf.Floor(CurrentTime /60).ToString();

        if (isCounting)
        {
            elapsedTime += Time.deltaTime;
        }
    }
}
