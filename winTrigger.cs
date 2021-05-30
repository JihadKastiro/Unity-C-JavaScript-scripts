using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//using UnityEngine.Advertisements;
using UnityEngine.Monetization;
public class winTrigger : MonoBehaviour {
	public GameObject goal,light,player,fireworkbegin;
	public GameObject winPanel;
    public static winTrigger apppurchased;
    public int appPurch = 0;
    //public transformot b;
    public string placementId = "video";
    public string levelToUnlock;
	//public GameObject shell;
	//Quaternion ab = new Quaternion (shell.x, shell.y, shell.z, shell.w);
	//public Quaternion originalRotation;
	 
	//Vector3 a = new Vector3 (0,0,0);

	//public GameObject green;
	///public GameObject red;
	//public GameObject yellow;
	//public GameObject blue;
	public int Levelnb;

	public AudioSource soundSource;
	public AudioClip sound;

	private bool hasPlayedAudio;

    //public GameObject star1;
    ///public GameObject star2;
    //public GameObject star3;
    // Use this for initialization

    string gameId = "3298764";
    bool testMode = false;

    void Start()
    {
        Monetization.Initialize(gameId, testMode);
    }




    private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			goal.SetActive (false);
			player.SetActive (false);


			PlayerPrefs.SetFloat ("d" + Levelnb + "_d", 1);


			if (hasPlayedAudio == false) {

				soundSource.PlayOneShot (sound);
				hasPlayedAudio = false;
			}
			timerScript.tScripts.pauseTime = true;
			//winPanel.SetActive (true);
			light.SetActive(false);
		//	originalRotation = transform.rotation;

			saveLoad .saveAndLoad.saveGold();
			saveLoad.saveAndLoad.saveLighterQnt ();
			saveLoad.saveAndLoad.savetimerQnt ();

			//
			//GameObject clone = Instantiate(spawnPrefab, transform.position, transform.rotation) as GameObject;
			   //Instantiate (green, a, originalRotation);
			   
		      //	Instantiate (red, a, originalRotation);
 			   //Instantiate (yellow, a, originalRotation);
 			   //Instantiate (blue, a, originalRotation);
	//		Instantiate (green, transform.position, transform.rotation);

	//	Instantiate (red, transform.position, transform.rotation);
	//		Instantiate (yellow, transform.position, transform.rotation);
	//		Instantiate (blue, transform.position, transform.rotation);
		


		//	Instantiate (green, transform.position, transform.rotation);
        //    Instantiate (red, transform.position, transform.rotation);
		//	Instantiate (yellow, transform.position, transform.rotation);
		//	Instantiate (blue, transform.position, transform.rotation);

			saveCoinsWhenreplayed.scwps.startFireWork ();

			//PlayerPrefs.SetInt ("Level1_score",score);
			PlayerPrefs.SetFloat ("Level" + Levelnb + "_timeTaken",timerScript .tScripts. timeTaken);
			PlayerPrefs.SetFloat ("Level" + Levelnb + "_startTime",timerScript. tScripts. startTime);
			PlayerPrefs.SetInt (levelToUnlock, 1);

			StartCoroutine(ResetCoroutine(1));
		}
		//
	}//(timerScript.tScripts.startTime

	public IEnumerator ResetCoroutine(float delay)
	{
		yield return new WaitForSeconds(delay);
        ShowAd();
		winPanel.SetActive (true);
        //	if(timerScript.tScripts.timer>0)
        //	{
        //	star1.SetActive (true);
        //}
        //if(timerScript.tScripts.timer<=timerScript.tScripts.startTime*0.75)
        //{
        //	star2.SetActive (true);
        //}
        //if(timerScript.tScripts.timer<=timerScript.tScripts.startTime*0.5)
        //	{
        //		star3.SetActive (true);
        //}
        //ads//ads//ads//ads//ads//ads



    }



    // public int a = PlayerPrefs.GetInt("binary");
    /*
    public void showAdd(){
          //  if (a==10101010) {
            if (Advertisement.IsReady())
                {
                  //  Advertisement.Show();
                    Advertisement.Show ("video");
                }
               else { winPanel.SetActive(true); }

            //}

        }*/


    public void ShowAd()
    {
        StartCoroutine(ShowAdWhenReady());
    }
    private IEnumerator ShowAdWhenReady()
    {
        while (!Monetization.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.25f);
        }

        ShowAdPlacementContent ad = null;
        ad = Monetization.GetPlacementContent(placementId) as ShowAdPlacementContent;

        if (ad != null)
        {
            ad.Show();
        }
    }

}