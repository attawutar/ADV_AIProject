using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
	public GameObject nonglitch1;
	public GameObject nonglitch2;
	public GameObject nonglitch3;
	public GameObject nonglitch4;
	public GameObject nonglitch5;
	public GameObject nonglitch6;
	public GameObject nonglitch7;
	public GameObject nonglitch8;
	public GameObject nonglitch9;
	public GameObject nonglitch10;
	public GameObject nonglitch11;
	public GameObject nonglitch12;
	public GameObject nonglitch13;
	public GameObject nonglitch14;
	public GameObject nonglitch15;
	public GameObject nonglitch16;
	public GameObject nonglitch17;
	public GameObject nonglitch18;
	public GameObject glitch1;
	public GameObject glitch2;
	public GameObject glitch3;
	public GameObject glitch4;
	public GameObject glitch5;
	public GameObject glitch6;
	public GameObject glitch7;
	public GameObject glitch8;
	public GameObject glitch9;
	public GameObject glitch10;
	public GameObject glitch11;
	public GameObject glitch12;
	public GameObject glitch13;
	public GameObject glitch14;
	public GameObject glitch15;
	public GameObject glitch16;
	public GameObject glitch17;
	public GameObject glitch18;
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Check In!");
			nonglitch1.SetActive(false);
			nonglitch2.SetActive(false);
			nonglitch3.SetActive(false);
			nonglitch4.SetActive(false);
			nonglitch5.SetActive(false);
			nonglitch6.SetActive(false);
			nonglitch7.SetActive(false);
			nonglitch8.SetActive(false);
			nonglitch9.SetActive(false);
			nonglitch10.SetActive(false);
			nonglitch11.SetActive(false);
			nonglitch12.SetActive(false);
			nonglitch13.SetActive(false);
			nonglitch14.SetActive(false);
			nonglitch15.SetActive(false);
			nonglitch16.SetActive(false);
			nonglitch17.SetActive(false);
			nonglitch18.SetActive(false);
			glitch1.SetActive(true);
			glitch2.SetActive(true);
			glitch3.SetActive(true);
			glitch4.SetActive(true);
			glitch5.SetActive(true);
			glitch6.SetActive(true);
			glitch7.SetActive(true);
			glitch8.SetActive(true);
			glitch9.SetActive(true);
			glitch10.SetActive(true);
			glitch11.SetActive(true);
			glitch12.SetActive(true);
			glitch13.SetActive(true);
			glitch14.SetActive(true);
			glitch15.SetActive(true);
			glitch16.SetActive(true);
			glitch17.SetActive(true);
			glitch18.SetActive(true);
		}	
	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Check Out!");
			nonglitch1.SetActive(true);
			nonglitch2.SetActive(true);
			nonglitch3.SetActive(true);
			nonglitch4.SetActive(true);
			nonglitch5.SetActive(true);
			nonglitch6.SetActive(true);
			nonglitch7.SetActive(true);
			nonglitch8.SetActive(true);
			nonglitch9.SetActive(true);
			nonglitch10.SetActive(true);
			nonglitch11.SetActive(true);
			nonglitch12.SetActive(true);
			nonglitch13.SetActive(true);
			nonglitch14.SetActive(true);
			nonglitch15.SetActive(true);
			nonglitch16.SetActive(true);
			nonglitch17.SetActive(true);
			nonglitch18.SetActive(true);
			glitch1.SetActive(false);
			glitch2.SetActive(false);
			glitch3.SetActive(false);
			glitch4.SetActive(false);
			glitch5.SetActive(false);
			glitch6.SetActive(false);
			glitch7.SetActive(false);
			glitch8.SetActive(false);
			glitch9.SetActive(false);
			glitch10.SetActive(false);
			glitch11.SetActive(false);
			glitch12.SetActive(false);
			glitch13.SetActive(false);
			glitch14.SetActive(false);
			glitch15.SetActive(false);
			glitch16.SetActive(false);
			glitch17.SetActive(false);
			glitch18.SetActive(false);
		}
	}
}
