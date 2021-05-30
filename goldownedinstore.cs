using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class goldownedinstore : MonoBehaviour {

	public static goldownedinstore gOIS;
	public Text gText;
	public int GoldOwned;
	// Use this for initialization
	void Awake(){
		gOIS=this;


	}
	void Start () {
		GoldOwned = MoneyScript.moneys.coins;
	}
	
	// Update is called once per frame
	void Update () {
		
		gText.text = GoldOwned.ToString();
	}
}
