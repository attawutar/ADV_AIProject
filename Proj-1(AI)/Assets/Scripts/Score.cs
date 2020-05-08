using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static double scoreValue = 0 ;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + scoreValue;
    }
}
