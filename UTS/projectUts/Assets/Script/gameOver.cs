using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameOver : MonoBehaviour
{
    Text txtOver;
    // Start is called before the first frame update
    void Start()
    {
        txtOver = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txtOver.text = CoinScore.score.ToString();
    }
}
