using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool isAlive = true;
    public GameObject[] enemyPrefabs;
    int enemyIndex;
    float randPosX, randPosZ;

    void Start()
    {
        InvokeRepeating("InstantiateEnemy", 0f, .5f);
    }

    void InstantiateEnemy()
    {
        if (isAlive) {
            enemyIndex = Random.Range(0, 3);
            randPosX = Random.Range(-12f, 12f);
            randPosZ = Random.Range(10f, 15f);
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(randPosX, 0.5f, randPosZ), 
                        enemyPrefabs[enemyIndex].transform.rotation);
        }
    }


    public void GameOver()
    {
        isAlive = false;
        Debug.Log("Game Over !!!");
    }
}
