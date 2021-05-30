 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableAndDisableObj : MonoBehaviour {
	public GameObject objectToDissappear;



	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			objectToDissappear.SetActive (false);

		}}
}
