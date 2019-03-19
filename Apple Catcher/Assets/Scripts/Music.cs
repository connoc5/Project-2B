using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    #region Variables
    public GameObject BackgroundSong;
    public GameObject Chicken;
    public GameObject Basket;
    public GameObject Splat;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(BackgroundSong);
        DontDestroyOnLoad(Chicken);
        DontDestroyOnLoad(Basket);
        DontDestroyOnLoad(Splat);
        SceneManager.LoadScene("Start");
    }
}
