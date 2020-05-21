using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float fireSpeed = 50f;
    SpawnAgent agent;

    // Update is called once per frame

    private void Start()
    {
        agent = GameObject.Find("SpawnAgent").GetComponent<SpawnAgent>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * fireSpeed * Time.deltaTime);
        DestroyObjectOffScreen();
    }

    private void DestroyObjectOffScreen()
    {
        if (transform.position.z > 20f || transform.position.z < -20f)
        {
            agent.DoneForAgent();
        }
    }
}
