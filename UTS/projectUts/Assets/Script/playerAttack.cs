using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public GameObject peluru;
    public Transform tempat;
    
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("isSerang",true);
            Instantiate(peluru, tempat.position,tempat.rotation);
        }else{
            anim.SetBool("isSerang",false);
        }
    }
}
