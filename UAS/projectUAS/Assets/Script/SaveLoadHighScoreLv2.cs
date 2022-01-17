using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighScoreLv2 : MonoBehaviour
{
    public Text txtHighScore;
    void Start()
    {
        txtHighScore.text = ambilScore().ToString();
    }

    public static int ambilScore()
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscoreLv2"))
        {
            PlayerPrefs.SetInt("highscoreLv2", 0);
        }
        else
        {
            hg = PlayerPrefs.GetInt("highscoreLv2");
        }
        return hg;
    }

    public static void simpanScore(int score)
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscoreLv2"))
        {
            PlayerPrefs.SetInt("highscoreLv2", 0);
        }
        else
        {
            hg = PlayerPrefs.GetInt("highscoreLv2");
            if (hg < CoinScore.score){
                hg = CoinScore.score;
            }
            PlayerPrefs.SetInt("highscoreLv2", hg);
        }
    }
}
