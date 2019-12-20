using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed = 2.5f;
    public float jumpForce = 10f;

    private Rigidbody2D r;
    
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        
        if (tag != "Player")
            tag = "Player";

        if (FindObjectOfType<LevelManager>() == null)
            Camera.main.gameObject.AddComponent<LevelManager>();
        
        FindObjectOfType<LevelManager>().observedObjects.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && r.IsTouching(new ContactFilter2D()))
        {
            r.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            GetComponent<Animator>().SetTrigger("Jump");
        }
        
        GetComponent<Animator>().SetBool("Run", x != 0);

        if (x < 0)
            GetComponent<SpriteRenderer>().flipX = true;
        else if (x > 0)
            GetComponent<SpriteRenderer>().flipX = false;
        
        r.position += new Vector2(x*Time.deltaTime*speed, 0);
    }
}
