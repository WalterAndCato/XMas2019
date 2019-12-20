using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DDOL : MonoBehaviour
{
    public string key = "Music";
    
    void Start()
    {
        if (FindObjectsOfType<DDOL>().Count(obj => obj.key == key) > 1)
        {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
    }
}
