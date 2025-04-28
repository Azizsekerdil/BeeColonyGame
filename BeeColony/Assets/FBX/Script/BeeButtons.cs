using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;

public class BeeButtons : MonoBehaviour
{
    string number;
    public int bees;

    public TMP_Text CopyBeeButtonText;
    public TMP_Text[] CopyBeesText;
    public int CounTextCopybee = 0;

    public bool beePrice = false;

    public static BeeButtons instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        beePrice = true;
    }

    // Update is called once per frame
    void Update()
    {
        number = "";
        number = PlayerPrefs.GetString(nameof(number), number);

        bees = 0;
        bees = PlayerPrefs.GetInt(nameof(bees),bees);

        CopyBeeButtonText.text = "100";
        CopyBeeButtonText.text = PlayerPrefs.GetString(nameof(CopyBeeButtonText), CopyBeeButtonText.text);

        CounTextCopybee = 0;
        CounTextCopybee = PlayerPrefs.GetInt(nameof(CounTextCopybee), CounTextCopybee); 
    }

    public void copyBee()
    {
        number = CopyBeeButtonText.gameObject.GetComponent<TMP_Text>().text;
        PlayerPrefs.SetString(nameof(number), number);
        int.TryParse(number, out bees);

        PlayerPrefs.SetInt(nameof(bees), bees);

        if (MoneyCanvas.scoreUI >= bees)
        {

            if (CounTextCopybee >= CopyBeesText.Length)
            {
                beePrice = false;
            }


            if (beePrice)
            {
                for (int i = 0; i < CopyBeesText.Length; i++)
                {
                    CopyBeeButtonText.gameObject.GetComponent<TMP_Text>().text = CopyBeesText[CounTextCopybee].text;
                    PlayerPrefs.SetString(nameof(CopyBeeButtonText), CopyBeeButtonText.text);
                }

                CounTextCopybee++;
                PlayerPrefs.SetInt(nameof(CounTextCopybee), CounTextCopybee);
            }

       
            BeeWorkerSpawn.instance.BeeProduct();

            MoneyCanvas.scoreUI -= bees;
            

        }




    }

 

 
}
