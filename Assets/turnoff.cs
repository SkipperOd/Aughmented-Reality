using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class turnoff : MonoBehaviour {

	//public GameObject gameObject;
	public GameObject ShowStartEndbtn;
	public GameObject startbtn;
	public static bool checkUdtInView;
	public static bool startimer;
	public GameObject CongratulationsPanel;
	public GameObject FailedPanel;
	public GameObject Restartbtn;
	public Text Cong;
	// Use this for initialization
	void Start () {
		startimer = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleObject(){

		var button = GameObject.Find("togglebutton").GetComponent<Button> ();
		if (button.GetComponentInChildren<Text> ().text == "Start")
		{
			button.GetComponentInChildren<Text> ().text = "Found IT!";
			startimer = true;
			Restartbtn.SetActive (true);
		} 
		else
		{
			if (checkUdtInView)
			{
				button.GetComponentInChildren<Text> ().text = "Start";
				startbtn.SetActive (false);
				ShowStartEndbtn.SetActive (false);
				startimer = false;
				CongratulationsPanel.SetActive (true);
				Restartbtn.SetActive (false);
			}
		}
	}
	public void ShowStartEndButton(){
		if(UDTEventHandler.checkquality){
			ShowStartEndbtn.SetActive (true);
			startbtn.SetActive (false);
		}

	}
	public void PlayAgain(){
		Application.LoadLevel ("3-UserDefinedTargets");
	}

}
