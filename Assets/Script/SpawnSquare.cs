using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SpawnSquare : MonoBehaviour
{
    public GameObject SquarePrefab;
    public GameObject ball;
    public int jumlah_spawn;
    void Start()
    {
        for (int i = 0; i < jumlah_spawn; i++)
        {
            default_spawn();
        }
    }
    private void Update()
    {
      if(ScoreManager.ScoreValue > ScoreManager.ScoreCek)
        {
            StartCoroutine(new_spawn());
            ScoreManager.ScoreCek += 1;
        }
    }
    IEnumerator new_spawn()
    {
        yield return new WaitForSeconds(3);
        default_spawn();
    }
    void default_spawn()
    {
        bool spawn = false;
        while (!spawn)
        {
            float spawnY = Random.Range(-3.8f, 3.8f);
            float spawnX = Random.Range(-7.66f, 7.66f);
            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);
            if (!ball)
            {
                continue;
            }
            else {
                if ((spawnPosition - ball.transform.position).magnitude < 3)
                {
                    continue;
                }
                else
                {
                    GameObject newObject = Instantiate(SquarePrefab, spawnPosition, Quaternion.identity);
                    newObject.transform.localScale = new Vector2(Random.Range(0.3f, 1f), Random.Range(0.3f, 1f));
                    spawn = true;
                }
            }
            
        }
    }
}
