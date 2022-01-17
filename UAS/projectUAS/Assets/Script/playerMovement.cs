using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rigidb;
    public float ms,jump;
    Animator anim;
    public static bool aktip;
    void Start()
    {
        aktip = false;
        rigidb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        // set horis inputan secara horizontal
        float horis = Input.GetAxisRaw("Horizontal");
        rigidb.velocity = new Vector2(horis * ms, rigidb.velocity.y);

        if (horis > 0 || horis < 0 ){
            transform.localScale = new Vector2(0.3f * horis, 0.3f);
        }

        if(Input.GetKeyUp("up")){
            anim.SetBool("isLompat",true);
            rigidb.velocity = Vector2.up * jump;
        }else{
            anim.SetBool("isLompat",false);
        }

        if(Input.GetKey("right") || Input.GetKey("left")){
            anim.SetBool("isJalan",true);
            anim.SetBool("isLari",true);
        }else{
            anim.SetBool("isJalan",false);
            anim.SetBool("isLari",false);
        }

    }

    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag.Equals("deadTag")){
            print("mati");
            anim.SetBool("isMati", true);
            //load scene
            SceneManager.LoadScene("Nilai");
        }
        if (coll.gameObject.tag.Equals("finishTag")){
            SceneManager.LoadScene("Nilai");
        }
        if (coll.gameObject.tag.Equals("jamurKuat")){
            aktip = true;
        }
    }

    public static bool getAktip(){
        return aktip;
    }
}
