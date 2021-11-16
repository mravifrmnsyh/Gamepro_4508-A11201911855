using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musuhScript : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag.Equals("peluruTag")){
            Destroy(gameObject);
        }
    }
}
