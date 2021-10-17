using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour
{
    public static int check = 0;
    public static int next_level = 0;
    public GameObject game_over;
    public GameObject next;

    void Update()
    {
        if (check == 1)
        {
            game_over.SetActive(true);
            check = 0;
            ScoreManager.ScoreValue = 0;
        }
        if (next_level == 1)
        {
            next.SetActive(true);
            next_level = 0;
        }
    }
}
