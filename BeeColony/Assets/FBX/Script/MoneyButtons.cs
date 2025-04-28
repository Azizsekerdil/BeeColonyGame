using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class MoneyButtons : MonoBehaviour
{
    string number="";
    public static int moneyHoney = 1;
    public int[] earnMoney;
    public static int priceCount = 0;
    public TMP_Text MoneyButtonText;
    public int moneyButtonPrice;


    public TMP_Text[] CopyMoneyText;
    public static int CountMoneyCopybee = 0;

    public GameObject ButtonMoneyy;
    public GameObject FlowerButton;

    public static MoneyButtons instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

       
 
        
      
       
    }

    void Update()
    {
        if (priceCount == 0)
        {
            MoneyButtonText.text = "10";
            moneyHoney = 1;
        }
        SetActive();
    }
    private bool SetActive()
    {

        if (priceCount > 20)
        {
            ButtonMoneyy.GetComponent<Button>().interactable = false;
            return false;
        }
        else
        {
            ButtonMoneyy.GetComponent<Button>().interactable = true;
            return true;
        }
    }
    public void makeMoney()
    {
        number = MoneyButtonText.gameObject.GetComponent<TMP_Text>().text;

        int.TryParse(number, out moneyButtonPrice);


        if (!SetActive())
        {
            return;
        }

        if (MoneyCanvas.scoreUI >= moneyButtonPrice)
        {

            for (int i = 0; i < earnMoney.Length; i++)
            {
                moneyHoney = earnMoney[priceCount];
            }
            priceCount++;
            MoneyButtonText.gameObject.GetComponent<TMP_Text>().text = CopyMoneyText[CountMoneyCopybee].text;


            CountMoneyCopybee++;

            MoneyCanvas.scoreUI -= moneyButtonPrice;
        }

    }
}
