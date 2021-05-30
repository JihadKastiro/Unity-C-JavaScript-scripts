using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class levelManager : MonoBehaviour {
	[System.Serializable]
	public class Level
	{
		public string LevelText;
		public int Unlocked;
		public bool IsInteractable;
		//public GameObject starPanel;
		//public GameObject starPanel;
		//public GameObject starPanel;
	//	public Button.ButtonClickedEvent OnClickEvent;

	}
	public List<Level> LevelList;
	public GameObject levelbutton;
	public Transform Spacer;




	// Use this for initialization
	void Start () {

//DeletAll ();
		FillList ();
		//Image img = GameObject.Find("StarPanel").GetComponent<Image> ();
	}

	void FillList()
	{

		foreach (var level in LevelList) {

			GameObject newbutton = Instantiate(levelbutton) as GameObject;

			levelButton button = newbutton.GetComponent<levelButton> ();

			button.LevelText.text = level.LevelText;
			if(PlayerPrefs.GetInt("Level"+button.LevelText.text)==1)
			{
				level.Unlocked = 1;
				level.IsInteractable = true;
				//Image img = GameObject.Find("StarPanel").GetComponent<Image> ();
			
				//GameObject panel=	button.GetComponentsInChildren ("StarPanel");
				//Image img=button.GetComponentsInChildren(StarPanel );
				//Image img=button.GetComponent<StarPanel> ();


				//	Image img=level.starPanel.GetComponent<Image> ();
				//img.color = UnityEngine.Color.blue;
				Image img2=button.panel.GetComponent<Image> ();
				Image img=button.starPanel.GetComponent<Image> ();
				img.color = UnityEngine.Color.blue;
				img2.color = UnityEngine.Color.blue;

				//img.color = UnityEngine.Color.blue;




				//Here to change color
				//.FindGameObjectsWithTag("levelbutton");

                 }
			button.unlocked = level.Unlocked;
			button.GetComponent<Button> ().interactable = level.IsInteractable;
			//button.GetComponents<Button> ().onClick.AddListener(() => loadLevels("Level"+button.LevelText.text));
			button.GetComponent<Button> ().onClick.AddListener(() => loadLevels("Level"+button.LevelText.text));
			//button.



		//	Image img=button.starPanel.GetComponent<Image> ();
		//	img.color = UnityEngine.Color.blue;



			//PlayerPrefs.SetFloat ("Level" + Levelnb+"_timeTaken", timeTaken);
			//PlayerPrefs.SetFloat ("Level" + Levelnb+"_startTime", startTime);
		/*	if (PlayerPrefs.GetInt ("Level" + button.LevelText.text + "_score") > 0) {

				button.star1.SetActive (true);

			} else {
				button.star1.SetActive (false);
			}
				
			if (PlayerPrefs.GetInt ("Level" + button.LevelText.text + "_score") <= 45) {

				button.star2.SetActive (true);

			} else {
			
				button.star2.SetActive (false);
			}



			if(PlayerPrefs.GetInt("Level"+button.LevelText.text+"_score")<=30){

				button.star3.SetActive (true);

			}else {
				button.star3.SetActive (false);
			}*/

			//PlayerPrefs.SetFloat ("Level" + Levelnb+"_timeTaken", timeTaken);
			//PlayerPrefs.SetFloat ("Level" + Levelnb+"_startTime", startTime);

			/*if(PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_timeTaken")>0){

				button.star1.SetActive (true);

			}
			if(PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_timeTaken")<=PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_startTime")*0.75){

				button.star2.SetActive (true);

			}else {
				button.star2.SetActive (false);
			}

			if(PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_timeTaken")<=PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_startTime")*0.5){

				button.star3.SetActive (true);

			}else {
				button.star3.SetActive (false);
			}*/
		
			if(PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_timeTaken")<PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_startTime")){
				if (PlayerPrefs.GetFloat ("Level" + button.LevelText.text + "_timeTaken") != 0) {
					Debug.Log (PlayerPrefs.GetFloat ("Level" + button.LevelText.text + "_timeTaken"));

					button.star1.SetActive (true);
				}

			}
			if(PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_timeTaken")<=PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_startTime")*0.75){
				if (PlayerPrefs.GetFloat ("Level" + button.LevelText.text + "_timeTaken") != 0) {
					button.star2.SetActive (true);
					Debug.Log (PlayerPrefs.GetFloat ("Level" + button.LevelText.text + "_timeTaken"));
				}
			}else {
				button.star2.SetActive (false);
			}

			if(PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_timeTaken")<=PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_startTime")*0.5){
				if (PlayerPrefs.GetFloat ("Level" + button.LevelText.text + "_timeTaken") != 0) {
					button.star3.SetActive (true);
					Debug.Log (PlayerPrefs.GetFloat ("Level" + button.LevelText.text + "_timeTaken"));
				}}else {
				button.star3.SetActive (false);
			}
			newbutton.transform.SetParent (Spacer);
		}
		SaveAll ();
		//		PlayerPrefs.SetFloat ("Level" + Levelnb, timeTaken);
	//	        PlayerPrefs.SetFloat ("Level" + Levelnb, startTime);
	}
	void SaveAll()
	{
	//	if (PlayerPrefs.HasKey ("Level")) {
	//		return;
	//	}else
	//	{
		GameObject [] allButtons=GameObject.FindGameObjectsWithTag("levelbutton");
			foreach (GameObject buttons in allButtons) {
				levelButton button = buttons.GetComponent<levelButton> ();
				PlayerPrefs.SetInt ("Level"+button.LevelText.text,button.unlocked);
			//}
		
		}
	}
	public void DeletAll()
	{
		PlayerPrefs.DeleteAll ();

	}
	public void loadLevels(string value){
	
		Application.LoadLevel(value);
	}
}
