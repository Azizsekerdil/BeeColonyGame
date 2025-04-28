using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using Unity.VisualScripting;


public class MoneyCanvas : MonoBehaviour
{
    public TMP_Text MoneyText;

    public bool moneyCanvas = false;

    public GameObject TargetTransfrom;

    public float moveSpeed;
    public float FirstLength;
    public float stopDistanceOne;

    public  Vector3 StartPostion = Vector3.zero;

    public static float staticY = float.MinValue;

    public static int scoreUI = 0;

    public static MoneyCanvas instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;   

        if(staticY == float.MinValue)
        {
            staticY = transform.position.y;
        }

        StartPostion = new Vector3(transform.position.x,staticY,transform.position.z);



        InvokeRepeating("EarnMoney", 1, 1);

    }
    void EarnMoney()
    {
        scoreUI += MoneyButtons.moneyHoney;
    }
    // Update is called once per frame
    void Update()
    {      
        MoneyText.GetComponent<TMP_Text>().text = "$" + MoneyButtons.moneyHoney.ToString();

        FirstLength = Vector3.Distance(transform.position, TargetTransfrom.transform.position);

        transform.position = Vector3.Lerp(transform.position, TargetTransfrom.transform.position, moveSpeed * Time.deltaTime);

        if (FirstLength < stopDistanceOne)
        {
            

            BeeUI.instance.ScoreTextUI.text = scoreUI.ToString();

            transform.position = StartPostion;



        }

    }

   
}
