using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class Replay : MonoBehaviour
{
    private InterstitialAd interstitial;
    public Canvas myCanvas;

    // 전면 광고 요청 함수
    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-7153366510996370/4348926086";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    // 게임 재실행 함수
    public void ReplayGame()
    {

        RequestInterstitial();
        //When you want call Interstitial show
        StartCoroutine(showInterstitial());

        IEnumerator showInterstitial()
        {
            while (!this.interstitial.IsLoaded())
            {
                yield return new WaitForSeconds(0.2f);
            }
            this.interstitial.Show();
            myCanvas.sortingOrder = -1;
        }

    }

    // 광고가 꺼졌을 때
    public void HandleOnAdClosed(object sender, System.EventArgs args)
    {
        // 게임 재실행
        SceneManager.LoadScene("PlayScene");
    }
}
