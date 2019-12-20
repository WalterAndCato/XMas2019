using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Level4 : Level
{
    public GameObject zuckerstange;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(base.SpawnUniversalSticks(zuckerstange,-0.9f,4f, -2));
    }

    private void Bewegen(GameObject instantiated)
    {
        instantiated.GetComponent<Rigidbody2D>().velocity = new Vector2(SpeedZuckerstange, 0);
    }
}
