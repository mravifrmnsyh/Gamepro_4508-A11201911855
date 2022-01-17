using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musuhMove : MonoBehaviour
{
    private Rigidbody2D rigidb;
    public float spd;
    public bool batas;
    void Start()
    {
        //set batas menjadi true
        batas = true;
        // inisialisasi komponen rigidbody
        rigidb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // kondisi pergerakan dan rotasi object
        if (batas){
            rigidb.velocity = new Vector2(spd, rigidb.velocity.y);
            transform.rotation = Quaternion.Euler(0f,0f,0f);
        } else {
            rigidb.velocity = new Vector2(-spd, rigidb.velocity.y);
            transform.rotation = Quaternion.Euler(0f,180f,0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag.Equals("batasTag")){
            batas = !batas;
        }
    }
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag.Equals("peluruTag")){
            Destroy(gameObject);
        }
    }
}
