using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnLightOffTrigger : MonoBehaviour {
	public GameObject Lighton;
	public bool lightCondition = true;
	// Use this for initialization
	void Start () {
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			if (lightCondition == true) {
				Lighton.SetActive (false);
				lightCondition = false;


			}


		}
	}
}
