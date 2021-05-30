using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;
//using UnityEngine.Advertisements;
using UnityEngine.UI;
public class timerScript : MonoBehaviour
{
    public static timerScript tScripts;
    public float timer;
    public Text text;
    public bool pauseTime = false;
    public GameObject gameOverPanel, timerpanel, extraTimeViaAds;
    public float startTime;
    public float timeTaken;


    public bool hasWatchAd = false;
    public Text timeTakenToFinish;

    public AudioSource cameraSoundsource;
    public AudioSource soundSource;
    public AudioClip sound;



    public string placementId = "rewardedVideo";
   // public Button adButton;


    public AudioClip gameOversound;

    private bool hasPlayedAudio = true;

    public int Levelnb;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    // Use this for initialization
    public string onOrOff;


#if UNITY_IOS
   private string gameId = "3298765";
#elif UNITY_ANDROID
    private string gameId = "3298764";
#endif




    void Start()
    {/*
        adButton = GetComponent<Button>();
        if (adButton)
        {
            adButton.onClick.AddListener(ShowAd);
        }*/

        if (Monetization.isSupported)
        {
            Monetization.Initialize(gameId, true);
        }
    }


    void Awake()
    {
        tScripts = this;
        startTime = timer;

    }

    // Update is called once per frame
    void Update()
    {/*
        if (adButton)
        {
            adButton.interactable = Monetization.IsReady(placementId);
        }

        */

        if (pauseTime == false)
        {
            timer = timer - Time.deltaTime;
            timeTaken = startTime - timer;
            //	if(PlayerPrefs.GetFloat("Level"+button.LevelText.text+"_timeTaken")


            onOrOff = PlayerPrefs.GetString("soundmode");
            //	if (onOrOff.Equals(true)) {
            //	soundSource.PlayOneShot (sound);
            //	}else if(onOrOff.Equals(false)){
            //		soundSource.Pause ();
            //	}
            if (onOrOff == "true")
            {
                soundSource.PlayOneShot(sound);
            }
            else if (onOrOff == "false")
            {
                soundSource.Pause();
            }

        }
        if (timer <= 0)
        {
            pauseTime = true;
            timer = 0;
            Time.timeScale = 0;
            soundSource.Stop();

            timerpanel.SetActive(false);
            //extraTimeViaAds
            if (hasWatchAd == false)
            {
                //if (Advertisement.IsReady ())
                if (Monetization.isSupported)
                {
                    extraTimeViaAds.SetActive(true);

                }
                else
                {
                    if (hasPlayedAudio == true)
                    {
                        cameraSoundsource.PlayOneShot(gameOversound, 1);
                        hasPlayedAudio = false;
                    }
                    gameOverPanel.SetActive(true);

                }
            }
            else
            {
                if (hasPlayedAudio == true)
                {
                    cameraSoundsource.PlayOneShot(gameOversound, 1);
                    hasPlayedAudio = false;
                }
                gameOverPanel.SetActive(true);

            }

        }

        //soundSource.Stop ();
        //	cameraSoundsource.PlayOneShot (gameOversound);
        //if	(hasPlayedAudio==true){
        //		cameraSoundsource.PlayOneShot(gameOversound,1);
        //		hasPlayedAudio = false;
        //	}


        text.text = timer.ToString("0");
        //PlayerPrefs.SetFloat ("Level" + Levelnb + "_timeTaken", timeTaken);
        //	PlayerPrefs.SetFloat ("Level" + Levelnb + "_startTime", startTime);
        timeTakenToFinish.text = timeTaken.ToString("0");
        if (timeTaken > 0)
        {
            star1.SetActive(true);
        }
        if (timeTaken <= startTime * 0.75)
        {//startTime*0.75  45
            star2.SetActive(true);
        }
        else
        {
            star2.SetActive(false);
        }
        if (timeTaken <= startTime * 0.5)
        {//startTime*0.5  30
            star3.SetActive(true);
        }
        else
        {
            star3.SetActive(false);
        }
    }

    /*
    void ShowAd()
    {
        ShowAdCallbacks options = new ShowAdCallbacks();
        options.finishCallback = HandleShowResult;
        ShowAdPlacementContent ad = Monetization.GetPlacementContent(placementId) as ShowAdPlacementContent;
        ad.Show(options);
    }
    */

    public IEnumerator ResetCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay);
        cameraSoundsource.Pause();

    }
    public void timeCounterPause()
    {
        //pauseTime = true;

    }
    public void yesToAd()
    {
        // PlayRewardedAd();
        showAdreward();
        Time.timeScale = 1;
        pauseTime = false;
        soundSource.Play();
    }
    public void noToAd()
    {
        extraTimeViaAds.SetActive(false);
        gameOverPanel.SetActive(true);
    }






    /*

    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            // Reward the player
            timer = timer + 10;
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("The player skipped the video - DO NOT REWARD!");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.LogError("Video failed to show");
        }







     public void PlayRewardedAd()
        {
            UnityAdsManager.Instance.ShowRewardedAd(HandleAdResult);
        }

        private void OnAdClosed(ShowResult result)
        {
            Debug.Log("regular ad closed");
        }

        private void HandleAdResult(ShowResult result)
        {
            switch (result)
            {
                case ShowResult.Finished:
                    //Debug.Log ("PLayer Gains +5 gems");
                    MoneyScript.moneys.coins = MoneyScript.moneys.coins + 10;
                    break;
                case ShowResult.Skipped:
                    Debug.Log("player Didnot watch the full ad");
                    break;
                case ShowResult.Failed:
                    Debug.Log("player failed to lunch  add");
                    break;
            }


        }


    */
        public void showAdreward(){
            //if(Advertisement.IsReady())
            if (Monetization.isSupported)
            {
            //Advertisement.Show ();

            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleAdResult;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent(placementId) as ShowAdPlacementContent;
            ad.Show(options);
            //Monetization.Show ("3298764", new ShowOptions(){resultCallback=HandleAdResult});
            }}

        private void HandleAdResult(ShowResult result)
        {
            switch (result) {
            case ShowResult.Finished:
                //Debug.Log ("PLayer Gains +5 gems");
                timer=timer+10;
                extraTimeViaAds.SetActive(false);
                timerpanel.SetActive(true);
                Time.timeScale = 1;
                pauseTime = false;
                soundSource.Play();
                hasWatchAd = true;
                break;
            case ShowResult.Skipped:
                Debug.Log ("player Did not watch the full ad");
                break;
            case ShowResult.Failed:
                Debug.Log ("player failed to lunch  add");
                break;
            }
    }
    }

           
            
            