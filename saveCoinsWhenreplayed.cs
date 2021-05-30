using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveCoinsWhenreplayed : MonoBehaviour {
	public static saveCoinsWhenreplayed scwps;
	public GameObject green;
	public GameObject red;
	public GameObject yellow;
	public GameObject blue;


	void Start () {
		scwps = this;


	}
	public void startFireWork(){
		Instantiate (green, transform.position, transform.rotation);
		Instantiate (red, transform.position, transform.rotation);
		Instantiate (yellow, transform.position, transform.rotation);
		Instantiate (blue, transform.position, transform.rotation);
	}


}
