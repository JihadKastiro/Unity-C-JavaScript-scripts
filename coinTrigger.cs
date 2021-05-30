using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinTrigger : MonoBehaviour {
	public GameObject coin;
	public int coinValue;
	public int Levelnb;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetFloat ("d" + Levelnb + "_d")==1){
			coin.SetActive (false);
			//			PlayerPrefs.SetFloat ("c" + Levelnb + "_c", 0);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			coin.SetActive (false);
			MoneyScript.moneys.coins = MoneyScript.moneys.coins + coinValue;
		}

	}
}
