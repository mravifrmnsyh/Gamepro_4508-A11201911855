using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public static int score;
    Text txtScore;
    void Start()
    {
        score = 0;
        // mendapatkan komponen text
        txtScore = GetComponent<Text>();
    }
    void Update()
    {
        txtScore.text = "Score : "+score.ToString();
        //memanggil method savehaighscore
        SaveLoadHighScore.simpanScore(score);
        if (codeGUI.getLv2()==true){
            SaveLoadHighScoreLv2.simpanScore(score);
        }
        if (codeGUI.getLv3()==true){
            SaveLoadHighScoreLv3.simpanScore(score);
        }
        // kondisi jika highscore mendapat 30 maka naik level
        if (PlayerPrefs.GetInt("highscoreLv1") == 30){
            codeGUI.simpanLevel(1);
        }
        if (PlayerPrefs.GetInt("highscoreLv2") == 30){
            codeGUI.simpanLevel(2);
        }
    }
}
