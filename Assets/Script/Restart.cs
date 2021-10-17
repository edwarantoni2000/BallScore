using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void main_menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Next(int go_to)
    {
        ScoreManager.ScoreValue = 0;
        ScoreManager.ScoreCek = 0;
        SceneManager.LoadScene(go_to);
    }
    public void retry()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
