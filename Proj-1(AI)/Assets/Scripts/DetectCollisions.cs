using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour


{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        Score.scoreValue += 0.5;

        if (other.gameObject.name == "Player")
        {
            GameObject.Find("EnemySpawner").SendMessage("GameOver");
        }
    }
}
