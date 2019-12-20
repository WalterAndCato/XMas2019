using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player")
            return;
        Debug.Log("OnTrigger...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameManager.IncreaseLevel();
        PlayerPrefs.SetInt("lifes", PlayerPrefs.GetInt("lifes", 0) + 1);
    }
    
}
