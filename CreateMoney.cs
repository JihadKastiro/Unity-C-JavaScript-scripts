using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMoney : MonoBehaviour {
	public  int getMoney;
	
	void Awake () {

	}
	
	// Update is called once per frame
	void Update () {
		MoneyScript.moneys.addCoins (3);
	}
}
