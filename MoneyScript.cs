using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyScript : MonoBehaviour {
	public int coins=0;
	public static MoneyScript moneys;
	public Text coinText;
	// Use this for initialization
	void Update()
	{
		coinText.text = coins.ToString ();
	}
	void Awake(){


		moneys = this;
	}
	public void addCoins(int money)
	{
		coins += money;
		//coinText.text = coins.ToString ();
	}
}
