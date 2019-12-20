using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static string PREFS_LIFES = "lifes";
    
    private static int Levelvalue = 0;
    public Text LevelText;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public Boolean Life1;
    public Boolean Life2;
    public Boolean Life3;
    
    public static void IncreaseLevel()
    {
        Levelvalue += 1;
    }    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
        UpdateLevelText();
    }
    
    private void StartGame()
    {
        Debug.Log("Game started");
    }

    private void UpdateLevelText()
    {
        LevelText.text = $"Level {GameManager.Levelvalue}";
        //if (PlayerPrefs.GetInt("lifes") )
        if (PlayerPrefs.GetInt(GameManager.PREFS_LIFES) < 1)
        {
            life3.SetActive(false);
            life2.SetActive(false);
            life1.SetActive(false);
        }
        else if (PlayerPrefs.GetInt(GameManager.PREFS_LIFES) < 2)
        {
            life3.SetActive(false);
            life2.SetActive(false);
        }
        else if (PlayerPrefs.GetInt(GameManager.PREFS_LIFES) < 3)
        {
            life3.SetActive(false);
        }
        else
        {
            life3.SetActive(true);
            life2.SetActive(true);
            life1.SetActive(true);
        }
    }
}
