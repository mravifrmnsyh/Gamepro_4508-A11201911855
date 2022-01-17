using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowLv3 : MonoBehaviour // camerafollow level3
{
    public GameObject player; // membuat var player tipe GameObject diisi dengan caracter
    private Vector3 vec; // var vec tipe Vector3
    void Start()
    {
        // mengisi var vec dengan pengurangan posisi camera dengan posisi player
        vec = transform.position - new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z); 
    }
    void LateUpdate()
    {
        // merubah posisi camera dengan posisi player ditambah var vec
        transform.position = player.transform.position + vec;
    }
}
