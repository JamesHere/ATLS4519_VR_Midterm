using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballLunch : MonoBehaviour
{
    float speed = 8;
    public GameObject Player;
    public Rigidbody orb;
    AudioSource audio;
    public Transform lunchPoint;
    float timer = 0;

    void Start()
    {
        Player = GameObject.Find("camera");
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            if (timer >= 0.5f)
            {
                audio.Play();
                Rigidbody clone;
                clone = (Rigidbody)Instantiate(orb, lunchPoint.position, lunchPoint.rotation);
                clone.velocity = transform.TransformDirection(Vector3.forward * speed);

                timer = 0;
            }

        }
        if (Player.GetComponent<damage>().gameOver == 1)
        {
            Destroy(this.gameObject);
            Destroy(this);
        }
    }
}
