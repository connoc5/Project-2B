﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    #region Variables
    public string sceneName;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ChangeCurrentScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
