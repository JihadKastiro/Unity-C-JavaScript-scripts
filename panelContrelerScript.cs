using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelContrelerScript : MonoBehaviour {
	public GameObject showPanel, hidePanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showThePanel()
	{
		showPanel.SetActive (true);


	}

	public void hideThePanel()
	{
		hidePanel.SetActive (false);


	}
	public void pauseTheTime()
	{
		Time.timeScale = 0;


	}
	public void resumeTheTime()
	{
		Time.timeScale = 1;


	}
}
