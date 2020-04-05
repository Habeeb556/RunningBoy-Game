using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour
{
    private Text time1;
    public static float Timer = 15;
    public GameObject Timeup;
    public GameObject Restart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time1 = GetComponent<Text>();
        Timer -= Time.deltaTime;
        time1.text = "Time Left: " + Mathf.Round(Timer);
        if(Timer<=0)
        {
            Timeup.gameObject.SetActive(true);
            Restart.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
