using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class SpawnAgent : Agent
{
    float moveSpeed = 20f;
    public GameObject bullet;
    TraningArea traningArea;
    SpawnAcademy spawnAcademy;

    Vector3 target;

    int enemyNum;
    // Start is called before the first frame update
    public override void InitializeAgent()
    {
        base.InitializeAgent();
        traningArea = GameObject.Find("Area").GetComponent<TraningArea>();
        spawnAcademy = FindObjectOfType<SpawnAcademy>();
    }

    public override void AgentReset()
    {
        traningArea.ResetArea();
    }

    public override void CollectObservations()
    {
        AddVectorObs(this.transform.position);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float distanceToEnd = 40;
        foreach (GameObject enemy in enemies)
        {
            float curDistanceToEnd = enemy.transform.position.z - (-20f);
            if (curDistanceToEnd < distanceToEnd)
            {
                distanceToEnd = curDistanceToEnd;
                target = enemy.transform.position;
            }
        };

        AddVectorObs(target);
    }

    public override void AgentAction(float[] action)
    {
        float controlSignal;
        controlSignal = action[0];
        transform.Translate(Vector3.right * moveSpeed * controlSignal * Time.deltaTime);

        if (action[1] == 1f)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3);
            Instantiate(bullet, position, bullet.transform.rotation);
        }

        if (transform.position.x < -13f || transform.position.x > 13f)
        {
            DoneForAgent();
        }
    }

    public override float[] Heuristic()
    {
        var action = new float[2];
        float hitAction = 0f;
        action[0] = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hitAction = 1f;
            action[1] = hitAction;
        }
        return action;
    }

    public void AddRewardForAgent(float rewards)
    {
        AddReward(rewards);
    }

    public void DoneForAgent()
    {
        Done();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") == true)
        {
            DoneForAgent();
        }
    }

    private void Update()
    {
    }

}