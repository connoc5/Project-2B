using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    #region Variables
    public Text HighScore1;
    public Text HighScore2;
    public Text HighScore3;
    public Text HighScore4;
    public Text HighScore5;
    public Text HighScore6;
    public Text HighScore7;
    public Text HighScore8;
    public Text HighScore9;
    public Text HighScore10;

    private int i=0;
    private int j=0;
    private int Current=0;
    public int[] Array = new int[10];
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        int CurrentScore = PlayerPrefs.GetInt("CurrentScore");
        Current = CurrentScore;

        if (PlayerPrefs.HasKey("HighScore1") == true) { Array[0] = PlayerPrefs.GetInt("HighScore1"); }
        else { Array[0] = 0; }
        if (PlayerPrefs.HasKey("HighScore2") == true) { Array[1] = PlayerPrefs.GetInt("HighScore2"); }
        else { Array[1] = 0; }
        if (PlayerPrefs.HasKey("HighScore3") == true) { Array[2] = PlayerPrefs.GetInt("HighScore3"); }
        else { Array[2] = 0; }
        if (PlayerPrefs.HasKey("HighScore4") == true) { Array[3] = PlayerPrefs.GetInt("HighScore4"); }
        else { Array[3] = 0; }
        if (PlayerPrefs.HasKey("HighScore5") == true) { Array[4] = PlayerPrefs.GetInt("HighScore5"); }
        else { Array[4] = 0; }
        if (PlayerPrefs.HasKey("HighScore6") == true) { Array[5] = PlayerPrefs.GetInt("HighScore6"); }
        else { Array[5] = 0; }
        if (PlayerPrefs.HasKey("HighScore7") == true) { Array[6] = PlayerPrefs.GetInt("HighScore7"); }
        else { Array[6] = 0; }
        if (PlayerPrefs.HasKey("HighScore8") == true) { Array[7] = PlayerPrefs.GetInt("HighScore8"); }
        else { Array[7] = 0; }
        if (PlayerPrefs.HasKey("HighScore9") == true) { Array[8] = PlayerPrefs.GetInt("HighScore9"); }
        else { Array[8] = 0; }
        if (PlayerPrefs.HasKey("HighScore10") == true) { Array[9] = PlayerPrefs.GetInt("HighScore10"); }
        else { Array[9] = 0; }

        for (i = 0; i < Array.Length; i++)
        {
            if (Current > Array[i])
            {
                print(Current);
                for (j = 9; j > i; j--)
                {
                    Array[j] = Array[j - 1];
                }
                Array[i] = Current;
                break;
            }
            else
            {
                continue;
            }
        }
        HighScore1.text = "High Score 1: " + Array[0];
        HighScore2.text = "High Score 2: " + Array[1];
        HighScore3.text = "High Score 3: " + Array[2];
        HighScore4.text = "High Score 4: " + Array[3];
        HighScore5.text = "High Score 5: " + Array[4];
        HighScore6.text = "High Score 6: " + Array[5];
        HighScore7.text = "High Score 7: " + Array[6];
        HighScore8.text = "High Score 8: " + Array[7];
        HighScore9.text = "High Score 9: " + Array[8];
        HighScore10.text = "High Score 10: " + Array[9];

        PlayerPrefs.SetInt("HighScore1", Array[0]);
        PlayerPrefs.SetInt("HighScore2", Array[1]);
        PlayerPrefs.SetInt("HighScore3", Array[2]);
        PlayerPrefs.SetInt("HighScore4", Array[3]);
        PlayerPrefs.SetInt("HighScore5", Array[4]);
        PlayerPrefs.SetInt("HighScore6", Array[5]);
        PlayerPrefs.SetInt("HighScore7", Array[6]);
        PlayerPrefs.SetInt("HighScore8", Array[7]);
        PlayerPrefs.SetInt("HighScore9", Array[8]);
        PlayerPrefs.SetInt("HighScore10", Array[9]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
