﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text WinText;
    public particleplayer trail; 

    private Rigidbody rb;
    private int count;


    void Start ()
    {

        rb = GetComponent <Rigidbody>();
        count = 0;
        SetCountText();
        WinText.text = "";
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            trail.Upgrade();
        }
    }
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 10)
        {
            WinText.text = "You Win!";

        }
        if(count == 10)
        {
            SceneManager.LoadScene("Mini game");

        }

    }


}

