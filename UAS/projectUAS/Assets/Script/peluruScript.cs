using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluruScript : MonoBehaviour
{
    float scPlay;
    void Start()
    {
        //mendapat scale x dari object player
        if (playerMovement.getAktip()==true){
            scPlay = GameObject.Find("Player").transform.localScale.x;
        }
    }
    void Update()
    {
        // kondisi kecepatan dan arah dari peluru
        if(scPlay == 0.3f){
            GetComponent<Rigidbody2D> ().velocity= new Vector2(8f, GetComponent<Rigidbody2D> ().velocity.y);
        }else{
            GetComponent<Rigidbody2D> ().velocity= new Vector2(-8f, GetComponent<Rigidbody2D> ().velocity.y);
        }
    }
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag.Equals("deadTag") || coll.gameObject.tag.Equals("endTag") || coll.gameObject.tag.Equals("coinTag"))
        {
            Destroy(gameObject);
        }
    }
}
