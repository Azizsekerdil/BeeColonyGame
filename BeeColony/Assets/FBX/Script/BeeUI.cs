using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class BeeUI : MonoBehaviour
{
    public GameObject Top;
    public GameObject MoneyText;
    //public GameObject Option;
    public GameObject BreakMenu;
    public GameObject Victory;
    public GameObject Fail;

    public GameObject Konfit;
    public GameObject NextLevel;
    public TMP_Text ScoreTextUI;
    public GameObject ScoreTextUIbg;
    public GameObject ScoreTextUIMoneyIcon;
    public GameObject[] HoneyIconUIText;

    public bool vibrate = false;

    public GameObject BeeDanceIcon;
    public GameObject BeeBoomIcon;
    public GameObject BeeNumberScore;
    public GameObject BeeNumberScoreMoney;
    public GameObject BeeNumberScorebg;

    public GameObject ProductButtonsBee;
    public GameObject ProductButtonsFlowers;
    public GameObject ProductButtonsHexagon;
    public GameObject ProductButtonsMoney;

    public GameObject[] Hexagons;
    public GameObject[] Flowers;

    public static BeeUI instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Top.SetActive(true);
        //Option.SetActive(false);
        MoneyText.SetActive(true);
        Victory.SetActive(false);
        Fail.SetActive(false);
        BreakMenu.SetActive(false);
        Konfit.SetActive(false);
     
        vibrate = true;

        BeeUI.instance.HoneyIconUIText[0].SetActive(false);
        BeeUI.instance.HoneyIconUIText[1].SetActive(false);
        BeeUI.instance.HoneyIconUIText[2].SetActive(false);
        BeeUI.instance.HoneyIconUIText[3].SetActive(false);
        BeeUI.instance.HoneyIconUIText[4].SetActive(false);
        NextLevel.SetActive(true);
        BeeBoomIcon.SetActive(true);
        BeeDanceIcon.SetActive(true);
        BeeNumberScore.SetActive(true);
        BeeNumberScorebg.SetActive(true);
        BeeNumberScoreMoney.SetActive(true);

        ScoreTextUI.gameObject.SetActive(true);
        ScoreTextUIbg.SetActive(true);
        ScoreTextUIMoneyIcon.SetActive(true);

        ScoreTextUI.text = "0";
        ScoreTextUI.text = PlayerPrefs.GetString(nameof(ScoreTextUI), ScoreTextUI.text);


    }
    void Update()
    {

        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {



            }

            if (touch.phase == TouchPhase.Ended)
            {


            }

            if (touch.phase == TouchPhase.Began)
            {
                Top.SetActive(false);
            }
        }
    }

    public void BeehomeButtons()
    {    
        

        BeeUI.instance.BreakMenu.SetActive(false);
        BeeUI.instance.HoneyIconUIText[0].SetActive(false);
        BeeUI.instance.HoneyIconUIText[1].SetActive(false);
        BeeUI.instance.HoneyIconUIText[2].SetActive(false);
        BeeUI.instance.HoneyIconUIText[3].SetActive(false);
        BeeUI.instance.HoneyIconUIText[4].SetActive(false);

}

    public void OpenOption()
    {
        //Option.SetActive(true);
        MoneyText.SetActive(false);
        Fail.SetActive(false);
        Victory.SetActive(false);
        NextLevel.SetActive(false);
        BeeBoomIcon.SetActive(false);
        BeeDanceIcon.SetActive(false);
        BeeNumberScore.SetActive(false);
        BeeNumberScorebg.SetActive(false);
        BeeNumberScoreMoney.SetActive(false);
    }

    public void CloseOption()
    {
        //Option.SetActive(false);
        MoneyText.SetActive(true);
        Fail.SetActive(false);
        Victory.SetActive(false);
        NextLevel.SetActive(true);
        BeeBoomIcon.SetActive(true);
        BeeDanceIcon.SetActive(true);
        BeeNumberScore.SetActive(true);
        BeeNumberScorebg.SetActive(true);
        BeeNumberScoreMoney.SetActive(true);
    }
    public void ChangeScenenOpenUI()
    {
        //Option.SetActive(true);
        MoneyText.SetActive(true);
        Fail.SetActive(false);
        Victory.SetActive(false);
        NextLevel.SetActive(true);
        BeeBoomIcon.SetActive(true);
        BeeDanceIcon.SetActive(true);
        BeeNumberScore.SetActive(true);
        ProductButtonsBee.SetActive(true);
        ProductButtonsFlowers.SetActive(true);
        ProductButtonsHexagon.SetActive(true);
        ProductButtonsMoney.SetActive(true);
        BeeNumberScore.SetActive(true);
        BeeNumberScorebg.SetActive(true);
        BeeNumberScoreMoney.SetActive(true);
    }


    public void ChangeScenenCloseUI()
    {
        //Option.SetActive(false);
        MoneyText.SetActive(false);
        Fail.SetActive(false);
        Victory.SetActive(false);
        NextLevel.SetActive(false);
        BeeBoomIcon.SetActive(false);
        BeeDanceIcon.SetActive(false);
        BeeNumberScore.SetActive(false);
        ProductButtonsBee.SetActive(false);
        ProductButtonsFlowers.SetActive(false);
        ProductButtonsHexagon.SetActive(false);
        ProductButtonsMoney.SetActive(false);
        BeeNumberScore.SetActive(true);
        BeeNumberScorebg.SetActive(true);
        BeeNumberScoreMoney.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
    }

    public void GameScene()
    {
        ChangeScenenOpenUI();
        SceneManager.LoadScene(0);
        
    }

    public void Restartgame()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.DeleteAll();
    }
    public void DansScene()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");

        Flowers = GameObject.FindGameObjectsWithTag("Flower");

        foreach (GameObject flows in Flowers)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(flows);
        }
        foreach (GameObject Hive in Hexagons)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(Hive);
        }
        //SceneManager.LoadScene(1);
        ChangeScenenCloseUI();
        SceneManager.LoadScene((1), LoadSceneMode.Additive);
    }

    public void BoomSceneOne()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");

        Flowers = GameObject.FindGameObjectsWithTag("Flower");

        foreach (GameObject flows  in Flowers)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(flows);
        }

        foreach (GameObject Hive in Hexagons)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(Hive);
        }
        //SceneManager.LoadScene(1);
        ChangeScenenCloseUI();
        SceneManager.LoadScene((2), LoadSceneMode.Additive);      
    }
    public void BoomSceneTwo()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");

        Flowers = GameObject.FindGameObjectsWithTag("Flower");

        foreach (GameObject flows in Flowers)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(flows);
        }

        foreach (GameObject Hive in Hexagons)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(Hive);
        }
        //SceneManager.LoadScene(1);
        ChangeScenenCloseUI();
        SceneManager.LoadScene((3), LoadSceneMode.Additive);
    }
    public void BoomSceneThree()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");

        Flowers = GameObject.FindGameObjectsWithTag("Flower");

        foreach (GameObject flows in Flowers)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(flows);
        }

        foreach (GameObject Hive in Hexagons)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(Hive);
        }
        //SceneManager.LoadScene(1);
        ChangeScenenCloseUI();
        SceneManager.LoadScene((4), LoadSceneMode.Additive);
    }
    public void BoomSceneFour()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");

        Flowers = GameObject.FindGameObjectsWithTag("Flower");

        foreach (GameObject flows in Flowers)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(flows);
        }

        foreach (GameObject Hive in Hexagons)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(Hive);
        }
        //SceneManager.LoadScene(1);
        ChangeScenenCloseUI();
        SceneManager.LoadScene((5), LoadSceneMode.Additive);
    }
    public void BoomSceneFive()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");

        Flowers = GameObject.FindGameObjectsWithTag("Flower");

        foreach (GameObject flows in Flowers)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(flows);
        }

        foreach (GameObject Hive in Hexagons)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(Hive);
        }
        //SceneManager.LoadScene(1);
        ChangeScenenCloseUI();
        SceneManager.LoadScene((6), LoadSceneMode.Additive);
    }
    public void BoomSceneSix()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");

        Flowers = GameObject.FindGameObjectsWithTag("Flower");

        foreach (GameObject flows in Flowers)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(flows);
        }

        foreach (GameObject Hive in Hexagons)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(Hive);
        }
        //SceneManager.LoadScene(1);
        ChangeScenenCloseUI();
        SceneManager.LoadScene((7), LoadSceneMode.Additive);
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

}
