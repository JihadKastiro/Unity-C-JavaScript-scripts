using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LighterScript : MonoBehaviour {

	public int lighter=0;
	public static LighterScript lighters;
	public Text LighterText;
	// Use this for initialization
	//public Text Gtext;
	public GameObject Lighton;

	void Update()
	{
		LighterText.text = lighter.ToString ();
	}
	void Awake(){


		lighters = this;
	}
	public void addlighter()
	{
		if (MoneyScript.moneys.coins >= 40) {
			lighter = lighter + 1;
	
			LighterText.text = "Qnt:" + lighter.ToString ();
		
		}
	}



	public void uselighter(int LighterNb)
	{if(Lighton.activeSelf==false){
			if(lighter>0){	
		Lighton.SetActive (true);
		lighter -= LighterNb;
		LighterText.text = lighter.ToString ();
			}
		}
	}
}
