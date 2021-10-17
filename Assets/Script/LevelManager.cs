﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] level_button;
    // Start is called before the first frame update
    void Start()
    {
        int level_unlocked = PlayerPrefs.GetInt("level_unlocked", 1);
        for (int i = 0; i < level_button.Length; i++)
        {
            level_button[i].interactable = false;
        }
        for (int i = 0; i < level_unlocked; i++)
        {
            level_button[i].interactable = true;
        }        
    }

    public void LoadLevel(int level_index)
    {
        ScoreManager.ScoreValue = 0;
        ScoreManager.ScoreCek = 0;
        SceneManager.LoadScene(level_index);
    }

    public void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Application.LoadLevel(Application.loadedLevel);
    }
}
