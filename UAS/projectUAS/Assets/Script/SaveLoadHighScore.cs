using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighScore : MonoBehaviour
{
    public Text txtHighScore;
    void Start()
    {
        txtHighScore.text = ambilScore().ToString();
    }

    public static int ambilScore()
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscoreLv1"))
        {
            PlayerPrefs.SetInt("highscoreLv1", 0);
        }
        else
        {
            hg = PlayerPrefs.GetInt("highscoreLv1");
        }
        return hg;
    }

    public static void simpanScore(int score)
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscoreLv1"))
        {
            PlayerPrefs.SetInt("highscoreLv1", 0);
        }
        else
        {
            hg = PlayerPrefs.GetInt("highscoreLv1");
            if (hg < CoinScore.score){
                hg = CoinScore.score;
            }
            PlayerPrefs.SetInt("highscoreLv1", hg);
        }
    }
}
