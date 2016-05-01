using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using UnityEngine.Advertisements;

public class AdMobController : MonoBehaviour {

	public string bannerTopAd;
	public string interstitialAd;
	private BannerView bannerView;
	private InterstitialAd interstitial;

	// Use this for initialization
	void Start () {
		requestIklan ();
	}

	private void RequestBanner()
	{
		string adUnitId = bannerTopAd;

		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
	}

	private void RequestInterstitial()
	{
		string adUnitId = interstitialAd;

		// Initialize an InterstitialAd.
		interstitial = new InterstitialAd(adUnitId);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		interstitial.LoadAd(request);
	}



	public void requestIklan(){
		RequestBanner ();
		RequestInterstitial ();
	}

	public void hapusIklan(){
		bannerView.Destroy ();
		interstitial.Destroy ();
	}

	public void tampilkanInterstitial(){
		if (interstitial.IsLoaded()) {
			interstitial.Show ();
		}/*
		if (Advertisement.IsReady ()) {
			Advertisement.Show ();
		}*/
	}

	public void tampilkanBanner(){
		bannerView.Show ();
	}

}
