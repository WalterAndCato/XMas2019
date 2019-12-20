using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Level3 : Level
{

    public GameObject zuckerstange;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(base.SpawnUniversalSticks(zuckerstange,1.9f,5f, SpeedZuckerstange * (-1)));
    }

/*
    IEnumerator SpawnSticks()
    {
        while (true)
        {
            var go = Instantiate(zuckerstange, new Vector3(7, Random.Range(1.9f, 1.9f)), Quaternion.identity);
            Bewegen(go);
            Destroy(go, 20f);
            yield return new WaitForSeconds(Random.Range(5f, 5f));
        }
    }
    */

    private void Bewegen(GameObject instantiated)
    {
        instantiated.GetComponent<Rigidbody2D>().velocity = new Vector2(-SpeedZuckerstange, 0);
    }
}
