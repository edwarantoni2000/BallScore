using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_diamond : MonoBehaviour
{
    public GameObject diamond_prefab;
    public GameObject ball;
    public int jumlah_spawn;
    void Start()
    {
        for (int i = 0; i < jumlah_spawn; i++)
        {
            default_spawn();
        }
    }
    void default_spawn()
    {
        bool spawn = false;
        while (!spawn)
        {
            float spawnY = Random.Range(-3.8f, 3.8f);
            float spawnX = Random.Range(-7.66f, 7.66f);
            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);
            if ((spawnPosition - ball.transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                GameObject newObject = Instantiate(diamond_prefab, spawnPosition, Quaternion.identity);
                spawn = true;
            }
        }
    }
}
