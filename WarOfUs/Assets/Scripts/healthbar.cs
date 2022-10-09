using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Image Healthbar1;
    public Image Healthbar2;
    public float p1h;
    public float p2h;
    public float p2m;
    public float p1m;
    public GameObject hbarimg;

    void Start()
    {   
        p1h = p1m;
        p2h = p2m;
        p1m = PlayerPrefs.GetFloat("p1m");
        p2m = PlayerPrefs.GetFloat("p2m");
        
    }

    // Update is called once per frame
    void Update()
    {
        Healthbar1.fillAmount = p1h / p1m;
        Healthbar2.fillAmount = p2h / p2m;
        p1h = PlayerPrefs.GetFloat("p1hn");
        p2h = PlayerPrefs.GetFloat("p2hn");
        PlayerPrefs.SetFloat("p1hp", p1h);
        PlayerPrefs.SetFloat("p2hp", p2h);
    }
}