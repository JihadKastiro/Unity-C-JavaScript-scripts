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
		
	}
	public List<Level> LevelList;
	public GameObject levelbutton;
	public Transform Spacer;




	// Use this for initialization
	void Start () {


		FillList ();
	
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
				

				Image img2=button.panel.GetComponent<Image> ();
				Image img=button.starPanel.GetComponent<Image> ();
				img.color = UnityEngine.Color.blue;
				img2.color = UnityEngine.Color.blue;

			
                 }
			button.unlocked = level.Unlocked;
			button.GetComponent<Button> ().interactable = level.IsInteractable;
			
			button.GetComponent<Button> ().onClick.AddListener(() => loadLevels("Level"+button.LevelText.text));
			


		
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
	
	}
	void SaveAll()
	{
	
		GameObject [] allButtons=GameObject.FindGameObjectsWithTag("levelbutton");
			foreach (GameObject buttons in allButtons) {
				levelButton button = buttons.GetComponent<levelButton> ();
				PlayerPrefs.SetInt ("Level"+button.LevelText.text,button.unlocked);
		
		
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
