using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timeFreezerScript : MonoBehaviour {

	public int timeFreezer=0;
	public static timeFreezerScript tFreezer;
	public Text LighterText;



	void Awake(){


		tFreezer = this;
	}
	void Update(){
		LighterText.text = timeFreezer.ToString ();

}
	public void addtimeFreezer()
	{
		
			if (MoneyScript.moneys.coins >= 25) {
			timeFreezer = timeFreezer + 1;
				MoneyScript.moneys.coins = MoneyScript.moneys.coins - 25;
				//int LighterOwned = LighterScript.lighters.lighter;
			LighterText.text = "Qnt:" + timeFreezer.ToString ();
				//	Gtext.text = MoneyScript.moneys.coins.ToString ();
			}
		}
	public void useTimeFreezer(int tFreezerNb)
	{
			if(timerScript .tScripts .pauseTime==false){
			if(timeFreezer>0){
				timerScript.tScripts.pauseTime = true;
		timeFreezer -= tFreezerNb;
			LighterText.text = timeFreezer.ToString ();}
		}}

}
