using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOffScreen : MonoBehaviour
{
    public float topScreen = 20f;
    public float bottomScreen = -20f;
   
    void Update()
    {
        if (transform.position.z > topScreen)
            Destroy(gameObject);
        else if (transform.position.z < bottomScreen)
            Destroy(gameObject);
    }
}
