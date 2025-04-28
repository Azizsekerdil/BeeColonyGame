using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using Unity.VisualScripting;

public class BeeBoomUI : MonoBehaviour
{
 
    public TMP_Text BeeBoomTimer;
    public float beeHometimer;

    public GameObject StartBoom;

    public bool vibrate = false;

    public static BeeBoomUI instance;
  
    void Start()
    {
        instance = this;
       
        StartBoom.SetActive(true);
        Invoke("CloseTaptoStart", 3f);

        beeHometimer = 30;
    }

    void CloseTaptoStart()
    {
        StartBoom.SetActive(false);
    }

    public void NoVibrate()
    {
        if (vibrate)
        {
            vibrate = false;
        }
        else if (vibrate == false)
        {
            vibrate = true;
        }
    }
 
    // Update is called once per frame
    void Update()
    {
      
        BeeBoomTimer.text = "" + (int)beeHometimer;

        if(beeHometimer >=0)
        {
            beeHometimer -= Time.deltaTime;
        }
        else
        {
            beeHometimer = 0;
        }

        if(beeHometimer == 0)
        {
            BeeUI.instance.GameScene();
            
        }


    }
}
