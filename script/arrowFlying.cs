using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowFlying : MonoBehaviour
{
    public GameObject Player;
    //public float Speed = 10f;
    Vector3 targetDirection;

    void Start()
    {
        Player = GameObject.Find("camera");
        targetDirection = Player.transform.position;
        transform.LookAt(targetDirection);
        this.GetComponent<Rigidbody>().AddForce(transform.forward * 300);
        Destroy(this.gameObject, 6);
    }


    void Update()
    {
        if (Player.GetComponent<damage>().gameOver == 1)
        {
            Destroy(this.gameObject);
            Destroy(this);
        }

    }
}
