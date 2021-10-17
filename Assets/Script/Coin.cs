using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        string tag = col.gameObject.tag;
        if (tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.ScoreValue += 1;
            if (ScoreManager.ScoreValue >= 50)
            {
                int c = PlayerPrefs.GetInt("level_unlocked");
                if (c<=5)
                {
                    int currentlevel = SceneManager.GetActiveScene().buildIndex;
                    if (currentlevel >= PlayerPrefs.GetInt("level_unlocked"))
                    {
                        PlayerPrefs.SetInt("level_unlocked", currentlevel + 1);
                    }
                }
                
                Game_Over.next_level += 1;

                
            }
            
        }
    }
}
