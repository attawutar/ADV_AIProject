using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float fireSpeed = 10f;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") == true)
        {
            agent.AddRewardForAgent(1.0f);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    private void DestroyObjectOffScreen()
    {
        if (transform.position.z > 20f || transform.position.z < -20f)
        {
            Destroy(gameObject);
        }
    }
}
