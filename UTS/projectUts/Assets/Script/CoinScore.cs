using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public static int score;
    Text txtScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        txtScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = "Score : "+score.ToString();
    }
}
