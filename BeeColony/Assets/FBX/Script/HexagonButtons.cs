using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class HexagonButtons : MonoBehaviour
{
    string number;
    public int hexagon;
    public TMP_Text HexagonButtonText;
    public Button HexagonButton;

    public TMP_Text[] HexagonsText;
    public int CounTextHexagon = 0;

    public static HexagonButtons instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        hexagon = 0;
        hexagon = PlayerPrefs.GetInt(nameof(hexagon), hexagon);

        CounTextHexagon = 0;
        CounTextHexagon = PlayerPrefs.GetInt(nameof(CounTextHexagon), CounTextHexagon);

        HexagonButtonText.text = "25";
        HexagonButtonText.text = PlayerPrefs.GetString(nameof(HexagonButtonText), HexagonButtonText.text);

        number = HexagonButtonText.gameObject.GetComponent<TMP_Text>().text;
        number = PlayerPrefs.GetString(nameof(number), number);
    }

    // Update is called once per frame
    void Update()
    {


        SetActive();
    }
    private  bool SetActive()
    {
        int currentHive = GameObject.FindGameObjectsWithTag("Kovan").Length;
        int max = (CamBee.levelCount + 1) * 9;
        

        if (currentHive < max)
        {
            HexagonButton.interactable = true;
            return true;
        }
        else
        {
            HexagonButton.interactable = false;
            return false;
        }

    }
    public void makeHive()
    {
        int currentHive = GameObject.FindGameObjectsWithTag("Kovan").Length;
        if (!SetActive())
        {
            return;
        }        

        number = HexagonButtonText.gameObject.GetComponent<TMP_Text>().text;
        
        int.TryParse(number, out hexagon);
       

        if (MoneyCanvas.scoreUI >= hexagon && HexagonBuilder.instance.hexagonPlace <= 70)

        {
            HexagonBuilder.instance.HexagonProduct();

            for (int i = 0; i < HexagonsText.Length; i++)
            {
                HexagonButtonText.gameObject.GetComponent<TMP_Text>().text = HexagonsText[CounTextHexagon].text;
            }

            CounTextHexagon++;

            MoneyCanvas.scoreUI -= hexagon;
        }
    }


}
