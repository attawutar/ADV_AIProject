using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float fireSpeed = 10f;
    void Update()
    {
        transform.Translate(Vector3.forward * fireSpeed * Time.deltaTime);
    }
}
