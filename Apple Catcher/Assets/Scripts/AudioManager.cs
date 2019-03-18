using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    #region Variables
    public GameObject Manager;
    private GameObject SongHolder = GameObject.Find("Song");
    public AudioSource Audio;
    public Slider Slider;
    private bool Open = false;
    #endregion
    // Start is called before the first frame update
    void Start()
    {

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
    public void SetVolume()
    {
        Audio.volume = Slider.value * 0.05f;
    }
}
