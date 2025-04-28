using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using System;
using Unity.VisualScripting;

public class Sound : MonoBehaviour
{
    public GameObject Ses;
    AudioSource SoundBee;
    public int sound = 0;

    void Start()
    {
        Ses = GameObject.FindGameObjectWithTag("SoundGame");
        SoundBee = Ses.GetComponent<AudioSource>();
        SoundBee.Play();
        sound = 2;
        sound = PlayerPrefs.GetInt(nameof(sound), sound);

    }

    // Update is called once per frame
    void Update()
    {
        if (sound == 1)
        {
            SoundBee.mute = true;
        }
        else if (sound == 2)
        {
            SoundBee.mute = false;
        }

    }

    public void SoundMute()
    {
        if (SoundBee.mute == true)
        {
            sound = 2;
            PlayerPrefs.SetInt(nameof(sound), sound);
        }
        else if (SoundBee.mute == false)
        {
            sound = 1;
            PlayerPrefs.SetInt(nameof(sound), sound);
        }
 
    }


}

//public void SoundMute()
//{
//    if (sound.mute == true)
//    {
//        sound.mute = false;
//    }
//    else if (sound.mute == false)
//    {
//        sound.mute = true;
//    }
//}

//public void MuteSound()
//{

//    if (Gamesource.mute == false || UIsource.mute == false)
//    {

//        Sound = 1;
//        PlayerPrefs.SetInt(nameof(Sound), Sound);
//    }
//    else if (Gamesource.mute == true || UIsource.mute == true)
//    {

//        Sound = 2;
//        PlayerPrefs.SetInt(nameof(Sound), Sound);
//    }
//}
