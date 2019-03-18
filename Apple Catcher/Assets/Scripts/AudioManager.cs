using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    #region Variables
    public GameObject Manager;
    public Slider MusicSlider;
    public Slider SFXSlider;
    private AudioSource Music;
    private AudioSource ChickenSFX;
    private AudioSource BasketSFX;
    private AudioSource SplatSFX;
    private bool Open = false;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        AudioSource BackgroundSong = GameObject.Find("Song").GetComponent<AudioSource>();
        Music = BackgroundSong;
        AudioSource Chicken = GameObject.Find("ChickenAudio").GetComponent<AudioSource>();
        ChickenSFX = Chicken;
        AudioSource Basket = GameObject.Find("BasketAudio").GetComponent<AudioSource>();
        BasketSFX = Basket;
        AudioSource Splat = GameObject.Find("SplatAudio").GetComponent<AudioSource>();
        SplatSFX = Splat;
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            MusicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        }
        else
        {
            MusicSlider.value = 2;
        }
        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        }
        else
        {
            SFXSlider.value = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OpenMenu()
    {
        if (Open == false)
        {
            Manager.SetActive(true);
            Open = true;
        }
        else
        {
            Manager.SetActive(false);
            Open = false;
        }
    }
    public void SetMusicVolume()
    {
        Music.volume = MusicSlider.value * 0.025f;
        PlayerPrefs.SetFloat("MusicVolume", MusicSlider.value);
    }
    public void SetSFXVolume()
    {
        ChickenSFX.volume = SFXSlider.value * 0.025f;
        BasketSFX.volume = SFXSlider.value * 0.125f;
        SplatSFX.volume = SFXSlider.value * 0.125f;
        PlayerPrefs.SetFloat("SFXVolume", SFXSlider.value);
    }
}
