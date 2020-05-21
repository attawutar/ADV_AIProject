using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   
        Destroy(gameObject);
        Destroy(other.gameObject);        
        if (other.gameObject.name == "Player")
        {
            GameObject.Find("EnemySpawner").SendMessage("GameOver");            
        }
        Debug.Log("Shot");
    }
}
