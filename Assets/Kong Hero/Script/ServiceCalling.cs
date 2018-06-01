using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Runtime.InteropServices;

public class ServiceCalling : MonoBehaviour {

	public void FaceBookInvite(){
//		ServiceManager.Instance.InviteFriend ();
		inviteFriendOnFB();
	}

	[DllImport ("__Internal")]
	private static extern void inviteFriendOnFB();

	private void friendInvited(){
		PlayerPrefs.SetInt (GlobalValue.Coins, GlobalValue.SavedCoins+50);
	}

//	public void RemoveAds(){
//		ServiceManager.Instance.RemoveAds ();
//	}

	public void WatchVideoAds(int coins){
		showRewardedVideo (coins);
//		ServiceManager.Instance.ShowRewardAds ();
	}

	[DllImport ("__Internal")]
	private static extern void showRewardedVideo(int coinsNumber);

	private void rewardedVideoWatched(string result){
		int coinsNumber = int.Parse(result);
		PlayerPrefs.SetInt (GlobalValue.Coins, GlobalValue.SavedCoins+coinsNumber);
	}

//	public void BuyItem1(){
//		ServiceManager.Instance.BuyItem1 ();
//	}
//
//	public void BuyItem2(){
//		ServiceManager.Instance.BuyItem2 ();
//	}
}
