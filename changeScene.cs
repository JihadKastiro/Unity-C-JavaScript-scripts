using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour {

	void Start()
	{
		Time.timeScale = 1;
	}

	void Update()
	{
	}


	public void loadTheScene(string a)
	{
		SceneManager.LoadScene (a);

	}

}
