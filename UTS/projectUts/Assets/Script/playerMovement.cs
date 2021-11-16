using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float ms,jump;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horis = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horis * ms, rb.velocity.y);

        if (horis > 0 || horis < 0 ){
            transform.localScale = new Vector2(0.3634224f * horis, 0.3487405f);
        }

        if(Input.GetKeyUp("up")){
            anim.SetBool("isLompat",true);
            rb.velocity = Vector2.up * jump;
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
        }
        if (coll.gameObject.tag.Equals("finishTag")){
            SceneManager.LoadScene("Nilai");
        }
        if (coll.gameObject.tag.Equals("deadTag")){
            SceneManager.LoadScene("Nilai");
        }
    }
    void die(){
        Time.timeScale=0;
    }
}
