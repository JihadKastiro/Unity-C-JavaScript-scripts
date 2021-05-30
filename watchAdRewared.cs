using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class watchAdRewared : MonoBehaviour{

#if UNITY_IOS
   private string gameId = "3298765";
#elif UNITY_ANDROID
    private string gameId = "3298764";
#endif

    public string placementId = "rewardedVideo";
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

    /*
	public void showAdd(){
		if(Advertisement.IsReady()){
			//Advertisement.Show ();
			Advertisement.Show ("rewardedVideo", new ShowOptions(){resultCallback=HandleAdResult});
		}}

	private void HandleAdResult(ShowResult result)
	{
		switch (result) {
		case ShowResult.Finished:
			//Debug.Log ("PLayer Gains +5 gems");
			MoneyScript.moneys.coins = MoneyScript.moneys.coins + 10;
			break;
		case ShowResult.Skipped:
			Debug.Log ("player Didnot watch the full ad");
			break;
		case ShowResult.Failed:
			Debug.Log ("player failed to lunch  add");
			break;
		}

	
    public void PlayAd()
    {
        UnityAdsManager.Instance.ShowRegularAd(OnAdClosed);

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


    }}*/

    public void showAdreward()
    {
        //if(Advertisement.IsReady())
        if (Monetization.isSupported)
        {
            //Advertisement.Show ();

            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleAdResult;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent(placementId) as ShowAdPlacementContent;
            ad.Show(options);
            //Monetization.Show ("3298764", new ShowOptions(){resultCallback=HandleAdResult});
        }
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
                Debug.Log("player Did not watch the full ad");
                break;
            case ShowResult.Failed:
                Debug.Log("player failed to lunch  add");
                break;
        }
    }


}
