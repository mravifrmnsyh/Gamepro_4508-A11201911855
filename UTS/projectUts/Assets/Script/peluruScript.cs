using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluruScript : MonoBehaviour
{
    float scalePlayer;
    // Start is called before the first frame update
    void Start()
    {
        scalePlayer = GameObject.Find("Player").transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(scalePlayer == 0.3634224f){
        GetComponent<Rigidbody2D> ().velocity= new Vector2(12f, GetComponent<Rigidbody2D> ().velocity.y);
        }else{
        GetComponent<Rigidbody2D> ().velocity= new Vector2(-12f, GetComponent<Rigidbody2D> ().velocity.y);
        }
    }
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag.Equals("deadTag") || coll.gameObject.tag.Equals("endTag")){
            Destroy(gameObject);
        }
    }
}
