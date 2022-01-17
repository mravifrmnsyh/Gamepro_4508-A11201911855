using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public GameObject pel;
    public Transform tempat;
    
    Animator an;
    void Start()
    {
        //inisialisasi komponen animator
        an = GetComponent<Animator>();
    }
    void Update()
    {
        //kondisi jika mengklik space animator di isi true, 
        if (playerMovement.getAktip()== true){
            if(Input.GetKeyDown(KeyCode.Space)){
                an.SetBool("isSerang",true);
                // menghasilkan object secara runtime
                Instantiate(pel, tempat.position,tempat.rotation);
            }else{
                an.SetBool("isSerang",false);
            }
        }
    }
}
