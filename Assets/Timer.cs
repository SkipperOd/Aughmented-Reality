using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public float Timeleft = 120.0f;
	public Text countdowntext;
	public GameObject failed;
	public GameObject togglebutton;
	public GameObject Restartbtn;
	//public GameObject failed;

	void Start(){
		
	}

	void Update(){
		if(turnoff.startimer){
			Timeleft -= Time.deltaTime;
			countdowntext.text = Timeleft.ToString("f2") + "s";
			if (Timeleft <= 0.0f) {
				failed.SetActive (true);
				togglebutton.SetActive (false);
				Restartbtn.SetActive (false);
			}
		}
	
	}

}
