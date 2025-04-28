using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using System.Threading;
using Button = UnityEngine.UI.Button;

public class BeeHome : MonoBehaviour
{
    public TMP_Text ScoreBee;

    public int[] beeNumberScore;
    public int[] beeNumberBoom;
    public int[] beeNumberDance;

    public static int score=0;
    public int level = 1;
    public int scoreBeeNumber;
    //public int camCount = 0;

    // Hazýr Deðiþ 10 Kamera var,10 tane Bool olmasý lazým

    public static bool BeeBoom = true;
    public static bool BeeBoomOne = true;
    public static bool BeeBoomTwo = true;
    public static bool BeeBoomThree = true;
    public static bool BeeBoomFour = true;
    public static bool BeeBoomFive = true;

    // 6 tane dans Animasyonu var, 6 tane bool olmasý lazým
    public static bool BeeDans = true;
    public static bool BeeDansOne = true;
    public static bool BeeDansTwo = true;
    public static bool BeeDansThree = true;
    public static bool BeeDansFour = true;
    public static bool BeeDansFive = true;




    public TMP_Text LevelText;
    public GameObject[] BeeHomes;
    public static BeeHome instance;

    public List<GameObject> gameUIs;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }
    void DanceBee()
    {

        if ((int)score > beeNumberDance[0] && BeeDans)
        {
            BeeDans = false;
            BeeUI.instance.DansScene();
        }
        if ((int)score > beeNumberDance[1] && BeeDansOne)
        {
            BeeDansOne = false;
            BeeUI.instance.DansScene();
        }
        if ((int)score > beeNumberDance[2] && BeeDansTwo)
        {
            BeeDansTwo = false;
            BeeUI.instance.DansScene();
        }
        if ((int)score > beeNumberDance[3] && BeeDansThree)
        {
            BeeDansThree = false;
            BeeUI.instance.DansScene();
        }
        if ((int)score > beeNumberDance[4] && BeeDansFour)
        {
            BeeDansFour = false;
            BeeUI.instance.DansScene();
        }
        if ((int)score > beeNumberDance[5] && BeeDansFive)
        {
            BeeDansFive = false;
            BeeUI.instance.DansScene();
        }
    }
    void BoomBee()
    {

        if ((int)score > beeNumberBoom[0] && BeeBoom == true)
        {


            BeeBoom = false;
            BeeUI.instance.BoomSceneOne();


        }
        if ((int)score > beeNumberBoom[1] && BeeBoomOne == true)
        {

            BeeBoomOne = false;
            BeeUI.instance.BoomSceneTwo();


        }
        if ((int)score > beeNumberBoom[2] && BeeBoomTwo == true)
        {

            BeeBoomTwo = false;
            BeeUI.instance.BoomSceneThree();


        }
        if ((int)score > beeNumberBoom[3] && BeeBoomThree == true)
        {

            BeeBoomThree = false;
            BeeUI.instance.BoomSceneFour();


        }
        if ((int)score > beeNumberBoom[4] && BeeBoomFour == true)
        {

            BeeBoomFour = false;
            BeeUI.instance.BoomSceneFive();
        }
        if ((int)score > beeNumberBoom[5] && BeeBoomFive == true)
        {

            BeeBoomFive = false;
            BeeUI.instance.BoomSceneSix();
        }

    }

    // Update is called once per frame
    void Update()
    {
        LevelText.gameObject.GetComponent<TMP_Text>().text = "Level " + (CamBee.levelCount+1);

        scoreBeeNumber = score;
        ScoreBee.text = scoreBeeNumber.ToString();


        BoomBee();
        DanceBee();
        ChangeLevel();

    }

    public void ChangeLevel()
    {
        if (CamBee.levelCount == 7)
        {
            foreach (GameObject ui in gameUIs)
            {
                ui.SetActive(false);

            }
            foreach (GameObject home in BeeHomes)
            {
                home.SetActive(true);
            }
           
            closeGame();
            return;
        }
        for (int i = 0; i < BeeHomes.Length; i++)
        {
            if (i == CamBee.levelCount && !BeeHomes[i].activeInHierarchy)
            {
                BeeHomes[i].SetActive(true);
            }
            else if (i != CamBee.levelCount && !BeeHomes[i].activeInHierarchy)
            {
                BeeHomes[i].SetActive(false);
            }
        }
        if (score >= beeNumberScore[CamBee.levelCount])
        {
            CamBee.levelCount++;
            FlowerMake.placeNum = 0;
            //Bee.instance.homeCount = CamBee.levelCount + 1;

            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("button"))
            {
                obj.GetComponent<Button>().enabled = true;
            }

            HexagonBuilder.instance.hexagonPlace = (CamBee.levelCount * 9) - 2;

        }

    }
    public void closeGame()
    {
        BeeUI.instance.Victory.SetActive(true);
        BeeUI.instance.Konfit.SetActive(true);
        Invoke("RestartGame", 9f);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.DeleteAll();
    }

}


