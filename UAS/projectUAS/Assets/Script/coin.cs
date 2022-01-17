using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll){
        // kondisi bila object bertubrukan dengan object lain dengan tag player
        if (coll.gameObject.tag.Equals("playerTag")){
            print("coin diambil");
            //menghilangkan gameobject
            Destroy(gameObject);
            //menambah score
            CoinScore.score+=1;
        }
    }
}
