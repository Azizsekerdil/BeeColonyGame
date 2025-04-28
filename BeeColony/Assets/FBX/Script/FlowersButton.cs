using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;
using System.Linq;

public class FlowersButton : MonoBehaviour
{
    string number;
    public TMP_Text FlowerButtonText;
    public int flowerButtonPrice;
    public TMP_Text[] CopyFlowerText;
    public int CountMoneyCopybee = 0;

    public bool flowerPrice = true;
    public bool flowerPriceOne = true;
    public bool flowerPriceTwo = true;
    public bool flowerPriceThree = true;
    public bool flowerPriceFour = true;
    public bool flowerPriceFive = true;
    public bool flowerPriceSix = true;
    public bool flowerPriceSeven = true;

    public static FlowersButton instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        number = "";
        number = PlayerPrefs.GetString(nameof(number), number);

        FlowerButtonText.text = "100";
        FlowerButtonText.text = PlayerPrefs.GetString(nameof(FlowerButtonText), FlowerButtonText.text);

        flowerButtonPrice = 0;
        flowerButtonPrice = PlayerPrefs.GetInt(nameof(flowerButtonPrice), flowerButtonPrice);

        CountMoneyCopybee = 0;
        CountMoneyCopybee = PlayerPrefs.GetInt(nameof(CountMoneyCopybee), CountMoneyCopybee);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void FlowerCalculate()
    {
        for (int i = 0; i < CopyFlowerText.Length; i++)
        {
            FlowerButtonText.gameObject.GetComponent<TMP_Text>().text = CopyFlowerText[CountMoneyCopybee].text;
            PlayerPrefs.GetString(nameof(FlowerButtonText), FlowerButtonText.text);
        }

        CountMoneyCopybee++;
        PlayerPrefs.SetInt(nameof(CountMoneyCopybee), CountMoneyCopybee);
    }

    void FlowerPrice()
    {
        MoneyCanvas.scoreUI -= flowerButtonPrice;
        PlayerPrefs.SetInt(nameof(MoneyCanvas.scoreUI), MoneyCanvas.scoreUI);
    }

    public void makeFlower()
    {
        number = FlowerButtonText.gameObject.GetComponent<TMP_Text>().text;
        int.TryParse(number, out flowerButtonPrice);

        if (MoneyCanvas.scoreUI >= flowerButtonPrice )
        {

            if (!FlowerMake.instance.FlowerProduct())
            {
                return;
            }


            if (!(CountMoneyCopybee >= CopyFlowerText.Length))
            {
                FlowerCalculate();
            }
            FlowerPrice();
            
        }

    }
}




