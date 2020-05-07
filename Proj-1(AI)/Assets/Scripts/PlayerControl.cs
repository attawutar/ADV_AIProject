using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{    
    float horInput;
    public float moveSpeed = 20f;
    public float widthRange = 13f;
    public GameObject projecttilePrefab;    // new add
    public AudioClip soundFX;   // add new soundFX
    private AudioSource playerAudio;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (transform.position.x < -widthRange)
        {
            transform.position = new Vector3(-widthRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > widthRange)
        {
            transform.position = new Vector3(widthRange, transform.position.y, transform.position.z);
        }
        horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horInput * moveSpeed * Time.deltaTime);

        // new add        
            if (Input.GetKeyDown(KeyCode.Space))    // GetKey is always actived while pressed
            {
                Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3);
                Instantiate(projecttilePrefab, pos, projecttilePrefab.transform.rotation);
                playerAudio.PlayOneShot(soundFX, 1f);   // play explosion shot
            }
    }
}
