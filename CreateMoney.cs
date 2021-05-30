using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMoney : MonoBehaviour {
	public  int getMoney;
	//private MoneyScript Ms;

	// Use this for initialization
	void Awake () {
	//	Ms = GameObject.Find ("GameManager").GetComponent<MoneyScript> ();	
	//	int myCoins = getMoney;
	//	Ms.addCoins (getMoney);
		//MoneyScript.moneys.addCoins (3);
	}
	
	// Update is called once per frame
	void Update () {
		MoneyScript.moneys.addCoins (3);
	}
}
