using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonBuilder : MonoBehaviour
{
    public GameObject moneyCanvas; 
    public GameObject HexagonBuild;
  
    public GameObject[] HexagonPlace;

    public int hexagonPlace = 0;
    public int nextBuilding = 1;
    public float waitTime = 0.5f;

    public static HexagonBuilder instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        moneyCanvas.SetActive(true);

        hexagonPlace = -1;
        hexagonPlace = PlayerPrefs.GetInt(nameof(hexagonPlace), hexagonPlace);

    }

    // Update is called once per frame
    void Update()
    {
        if (nextBuilding > 0)
        {
            makeHexagon();
            nextBuilding = 0;   
        }
    }

    public void makeHexagon()
    {
        if(hexagonPlace < ((CamBee.levelCount + 1) * 9))
        {
            hexagonPlace++;

            GameObject Hexagon = Instantiate(HexagonBuild, HexagonPlace[hexagonPlace].transform.position, HexagonPlace[hexagonPlace].transform.rotation);
            Hexagon.tag = "Kovan";


            HiveYellow.instance.transform.position = HiveYellow.instance.StartPostion;
            MoneyCanvas.instance.transform.position = MoneyCanvas.instance.StartPostion;
        }
        else
        {
            Debug.Log("Girmedi:" + CamBee.levelCount + " " + hexagonPlace);
        }
       
    }

    public void HexagonProduct()
    {
        nextBuilding = 1;   
    }
}

