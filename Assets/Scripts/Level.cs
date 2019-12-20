using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
 
    public float SpeedZuckerstange = 0.2f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public IEnumerator SpawnUniversalSticks(GameObject go, float _yvalue, float _delaytime, float xspeed)
    {
        while (true)
        {
            var gameObject = Instantiate(go, new Vector3(10, Random.Range(_yvalue, _yvalue)), Quaternion.identity);
            Bewegen(gameObject,xspeed );
            FindObjectOfType<LevelManager>().observedObjects.Add(gameObject);
            yield return new WaitForSeconds(Random.Range(_delaytime, _delaytime));
        }
    }
    
    public void Bewegen(GameObject instantiated, float xspeed)
    {
        instantiated.GetComponent<Rigidbody2D>().velocity = new Vector2(xspeed, 0);
    }
    
}
