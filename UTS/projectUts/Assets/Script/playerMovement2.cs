using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement2 : MonoBehaviour
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
        rb.velocity = new Vector2(horis*ms, rb.velocity.y);

        if (horis > 0 || horis < 0 ){
            transform.localScale = new Vector2(1f * horis, 1f);
        }
    }
}
