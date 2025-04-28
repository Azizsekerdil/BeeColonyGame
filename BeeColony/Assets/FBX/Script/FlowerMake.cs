using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMake : MonoBehaviour
{
    public GameObject [] Flower;
  
    public GameObject[] FlowerPlace;
    public GameObject[] FlowerPlaceOne;
    public GameObject[] FlowerPlaceTwo;
    public GameObject[] FlowerPlaceThree;
    public GameObject[] FlowerPlaceFour;
    public GameObject[] FlowerPlaceFive;
    public GameObject[] FlowerPlaceSix;

   


    public static FlowerMake instance;
    public static List<GameObject> Places;
    public static int placeNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public bool placeFlower()
    {
        switch (CamBee.levelCount)
        {
            case 0:
                Places =new List<GameObject>(FlowerPlace);
                break;
            case 1:
                Places = new List<GameObject>(FlowerPlaceOne);
                break;
            case 2:
                Places = new List<GameObject>(FlowerPlaceTwo);
                break;
            case 3:
                Places = new List<GameObject>(FlowerPlaceThree);
                break;
            case 4:
                Places = new List<GameObject>(FlowerPlaceFour);
                break;
            case 5:
                Places = new List<GameObject>(FlowerPlaceFive);
                break;
            case 6:
                Places = new List<GameObject>(FlowerPlaceSix);
                break;
        }
        if (placeNum < 72)
        {
            GameObject chosenFlower = Flower[Random.Range(0, Flower.Length)];
            GameObject Flowers = Instantiate(chosenFlower, new Vector3(Places[placeNum].transform.position.x, chosenFlower.transform.position.y,
                                            Places[placeNum].transform.position.z), chosenFlower.transform.rotation);
            Flowers.tag = "Flower";

            placeNum ++;
            return true;
        }
        return false;
    }

    public bool FlowerProduct()
    {
        return placeFlower();
     
    }
}