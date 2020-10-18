using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monotization : MonoBehaviour {




	
	public static void LoadAds(){

	}

	public static void ShowAds(){

        Advertisements.Instance.ShowInterstitial();
    }

	public static void ShowAdsNonFB(){

        Advertisements.Instance.ShowInterstitial();
    }

	public static void LoadRewardAds(){
        		
	}

	public static void ShowRewardAds(){

        Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
    }

   public static void ShowBannerAd(){

        Advertisements.Instance.ShowBanner(BannerPosition.BOTTOM);
    }

	public static void HideBannerAd(){

        Advertisements.Instance.HideBanner();
    }

	public static void BroadcastReward(){

        Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
    }

    private static void CompleteMethod(bool completed)
    {
        if (completed)
        {
           
        }
        
    }


}
