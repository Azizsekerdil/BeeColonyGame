using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;

public class BeeDanceUI : MonoBehaviour
{

    public GameObject[] BeeDance;
    public GameObject StartDance;  
    public bool vibrate = false;
    public Button[] DanceButtons;
    public static BeeDanceUI instance;

    void Start()
    {
        instance = this;        
        StartDance.SetActive(true);
        Invoke("CloseTaptoStart",3f);
   
        for (int i = 0; i < BeeDance.Length; i++)
        {
            BeeDance[i].SetActive(false);
        }

        for (int i = 0; i < DanceButtons.Length; i++)
        {
            DanceButtons[i].gameObject.SetActive(true);
        }
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
    void CloseTaptoStart()
    {
        StartDance.SetActive(false);
    }
    void CloseAnimZero()
    {
        BeeUI.instance.GameScene();
    }
    void CloseAnimOne()
    {
       
        BeeUI.instance.GameScene();
    }
    void CloseAnimTwo()
    {
     
        BeeUI.instance.GameScene();
    }
    void CloseAnimThree()
    {
        
        BeeUI.instance.GameScene();
    }
    void CloseAnimFour()
    {
       
        BeeUI.instance.GameScene();
    }
    void CloseAnimFive()
    {
       
        BeeUI.instance.GameScene();
    }
    public void DanceZero()
    {
        BeeDance[0].SetActive(true);     
        Invoke("CloseAnimZero",11f);
        DanceButtons[0].interactable = false;
    }
    public void DanceOne()
    {
        BeeDance[1].SetActive(true);   
        Invoke("CloseAnimOne", 7f);
        DanceButtons[1].interactable = false;
    }
    public void DanceTwo()
    {
        BeeDance[2].SetActive(true);
        Invoke("CloseAnimTwo", 25f);
        DanceButtons[2].interactable = false;
    }
    public void DanceThree()
    {
        BeeDance[3].SetActive(true);   
        Invoke("CloseAnimThree", 11f);
        DanceButtons[3].interactable = false;
    }
    public void DanceFour()
    {
        BeeDance[4].SetActive(true); 
        Invoke("CloseAnimFour", 11f);
        DanceButtons[4].interactable = false;   
    }
    public void DanceFive()
    {
        BeeDance[5].SetActive(true);
        Invoke("CloseAnimFive", 11f);
        DanceButtons[5].interactable = false;
    }
}


//MoneyText.SetActive(true);
//MoneyText.GetComponent<TMP_Text>().text = BeeHome.instance.ScoreBee.gameObject.GetComponent<TMP_Text>().text;
//BeeUI.instance.ScoreTextUI.gameObject.SetActive(false);
//BeeUI.instance.ScoreTextUIbg.SetActive(false);
//BeeUI.instance.ScoreTextUIMoneyIcon.SetActive(false);
