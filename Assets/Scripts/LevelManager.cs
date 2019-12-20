using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> observedObjects = new List<GameObject>();
    public Vector3 minPos = new Vector3(-25, -13, -50);
    public Vector3 maxPos = new Vector3(25, 25, 50);
    public float updateTime = 0.25f;
    
    void Start()
    {
        InvokeRepeating(nameof(UpdateLevel), updateTime, updateTime);
    }

    private void UpdateLevel()
    {
        var toDestroy = observedObjects.Where(obj => obj.transform.position.x < minPos.x || obj.transform.position.y < minPos.y || obj.transform.position.x > maxPos.x || obj.transform.position.y > maxPos.y).ToList();

        foreach (var t in toDestroy)
        {
            if (t.tag == "Player")
            {
                if (PlayerPrefs.GetInt(GameManager.PREFS_LIFES) > 0)
                {
                    PlayerPrefs.SetInt(GameManager.PREFS_LIFES, PlayerPrefs.GetInt(GameManager.PREFS_LIFES) - 1);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    return;
                }
                
                PlayerPrefs.SetInt(GameManager.PREFS_LIFES, 3);
                SceneManager.LoadScene(0);
            }
            
            observedObjects.Remove(t);
            Destroy(t);
        }
    }
}
