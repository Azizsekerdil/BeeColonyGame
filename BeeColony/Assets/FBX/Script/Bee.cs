using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bee : MonoBehaviour
{
    public float insideBeeSpeed;
  


    public static Bee instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

      
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.gameObject.activeInHierarchy)
        {  
            this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, BeeHome.instance.BeeHomes[CamBee.levelCount].transform.position, insideBeeSpeed * Time.deltaTime);
        }
    }
}
