using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsManager : MonoBehaviour
{



    #region Instance
    private static UnityAdsManager instance;
    public static UnityAdsManager Instance
    {

        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UnityAdsManager>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned UnityAdsManager", typeof(UnityAdsManager)).GetComponent<UnityAdsManager>();
                }

            }
            return instance;



        }
        set {
            instance = value;
        }






    }


    #endregion



    [Header("Config")]
    [SerializeField] private string gameID = "";
    [SerializeField] private bool testmode = true;
    [SerializeField] private string rewardedVideoPlacementId;
    [SerializeField] private string regularPlacementId = "";

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        Advertisement.Initialize(gameID, testmode);
    }
    
    public void ShowRegularAd(System.Action<ShowResult> callback)
    {
#if UNITY_ADS
        if (Advertisement.IsReady(regularPlacementId))
        {
            ShowOptions so = new ShowOptions();
            so.resultCallback = callback;
            Advertisement.Show(regularPlacementId, so);

        }
        else
            Debug.Log("Ad not ready , consider waiting a bit more..or going online");
#else
        Debug.Log("Ads not supported");
#endif
    }

    public void ShowRewardedAd(System.Action<ShowResult> callback)
    {
#if UNITY_ADS
        if (Advertisement.IsReady(rewardedVideoPlacementId))
        {
            ShowOptions so = new ShowOptions();
            so.resultCallback = callback;
            Advertisement.Show(rewardedVideoPlacementId, so);

        }
        else
            Debug.Log("Ad not ready , consider waiting a bit more..or going online");
#else
        Debug.Log("Ads not supported");

#endif
    }

}