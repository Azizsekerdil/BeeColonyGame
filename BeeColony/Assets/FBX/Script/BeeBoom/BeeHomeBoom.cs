using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeHomeBoom : MonoBehaviour
{

    void Start()
    {
        transform.GetChild(1).transform.gameObject.SetActive(false);
    }

    void CloseObje()
    {
        transform.GetChild(1).transform.gameObject.SetActive(false);
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {

      
        transform.GetChild(0).transform.gameObject.SetActive(false);
        transform.GetChild(1).transform.gameObject.SetActive(true);
        Invoke("CloseObje", 2);
        


    }


}

