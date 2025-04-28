using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeeColony : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bee")
        {
            
            BeeHome.score++;
            PlayerPrefs.SetInt(nameof(BeeHome.score), BeeHome.score);
            Destroy(other.gameObject, 0.5f);

            if (BeeUI.instance.vibrate == true)
            {
                Handheld.Vibrate();
            }
        }
    }
}
