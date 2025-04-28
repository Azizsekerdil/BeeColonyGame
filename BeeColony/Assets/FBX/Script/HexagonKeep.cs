using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using Unity.VisualScripting;

public class HexagonKeep : MonoBehaviour
{
    public GameObject[] Hexagons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");
    }

    public void NextScene()
    {
        Hexagons = GameObject.FindGameObjectsWithTag("Kovan");


        foreach (GameObject Hive in Hexagons)
        {
            //Hive.SetActive(false);
            DontDestroyOnLoad(Hive);
        }


        //SceneManager.LoadScene(2);
        SceneManager.LoadScene((2), LoadSceneMode.Additive);
    }
}
