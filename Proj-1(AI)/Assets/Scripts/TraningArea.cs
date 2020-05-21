using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class TraningArea : MonoBehaviour
{
    public GameObject enemy;
    public GameObject agent;
    // Start is called before the first frame update
    private void Start()
    {
        ResetArea();
    }

    public void ResetArea()
    {
        Debug.Log("Reset");
        CancelInvoke("SpawnEnemy");
        DestroyAllEnemy();
        ResetPlayer();
        InvokeRepeating("SpawnEnemy", 0f, .5f);
    }

    void SpawnEnemy()
    {
        float randX = Random.Range(-12f, 12f);
        float randZ = Random.Range(10f, 15f);
        Instantiate(enemy, new Vector3(randX, 0.5f, randZ), enemy.transform.rotation);
    }

    void DestroyAllEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
    }

    void ResetPlayer()
    {
        agent.transform.position = new Vector3(0, 0.5f, -16f);
    }
}
