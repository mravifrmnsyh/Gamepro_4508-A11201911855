using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighScoreLv3 : MonoBehaviour
{
    public Text txtHighScore;
    void Start()
    {
        // mengeset txthighscore dari pemanggilan method loadhighscore 
        txtHighScore.text = ambilScore().ToString();
    }

    public static int ambilScore()
    {
        int hg = 0;
        //kondisi apakah terdapat key highscorelv3
        if (!PlayerPrefs.HasKey("highscoreLv3"))
        {
            // jika tidak ada mengeset highscorelv3 dengan 0
            PlayerPrefs.SetInt("highscoreLv3", 0);
        }
        else
        {
            //jika ada dipanggil dan dikembalikan nilainya
            hg = PlayerPrefs.GetInt("highscoreLv3");
        }
        return hg;
    }

    public static void simpanScore(int score)
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscoreLv3"))
        {
            PlayerPrefs.SetInt("highscoreLv3", 0);
        }
        else
        {
            // memanggil score di coinscore dan dibandingkan dengan nilai dari key highscore
            hg = PlayerPrefs.GetInt("highscoreLv3");
            if (hg < CoinScore.score){
                hg = CoinScore.score;
            }
            PlayerPrefs.SetInt("highscoreLv3", hg);
        }
    }
}
