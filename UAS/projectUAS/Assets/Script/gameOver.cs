using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameOver : MonoBehaviour
{
    Text txtOver;
    void Start()
    {
        txtOver = GetComponent<Text>();
    }
    void Update()
    {
        // menampilkan score di komponen text
        txtOver.text = CoinScore.score.ToString();
    }
}
