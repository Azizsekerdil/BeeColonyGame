using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeWorkerSpawn : MonoBehaviour
{
    public GameObject BeeSoldier;

    public GameObject HiveYellow;

    public int nextBee = 1;

    public float waitTime = 0.5f;


    public static BeeWorkerSpawn instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
       
    }

    // Update is called once per frame
    void Update()
    {

        if ( nextBee > 0)
        {
            nextBee = 0;
            makeBee();
            
                   
        }
        GameObject[] Hexagons = GameObject.FindGameObjectsWithTag("Kovan");
        
        foreach(GameObject Hexagon in Hexagons)
        {
            Debug.Log( Hexagon.name );
        }
    }

   
    public void makeBee()
    {
        GameObject[] Hexagons = GameObject.FindGameObjectsWithTag("Kovan");
        
        GameObject obj = Hexagons[Random.Range(0, Hexagons.Length)];

        if(obj.transform.childCount > 2)
        {
            GameObject BeeWorker = Instantiate(BeeSoldier, obj.transform.GetChild(1).transform.position, obj.transform.GetChild(1).transform.rotation);
            BeeWorker.tag = "Bee";
        }
        else
        {
            nextBee++;
        }
        




    }


    public void BeeProduct()
    {
        nextBee = 1;
      
    }

 
}

//if (!waitting && nextBee > 0)
//{
//    Invoke("makeBee", waitTime);
//    nextBee--;
//    waitting = true;
//}
