using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    public float set;
    private Vector3 vec;
    void Start()
    {
        // menjumlah posisi titik x player 
        set+=player.transform.position.x;
        vec = transform.position - new Vector3(set, player.transform.position.y, player.transform.position.z);
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + vec;
    }
}
