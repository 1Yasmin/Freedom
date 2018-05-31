using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class exitBtn : MonoBehaviour, IVirtualButtonEventHandler {
	public GameObject vbBtnObj;
	// Use this for initialization
	void Start () {
		vbBtnObj = GameObject.Find("Exit");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){ 
		Debug.Log("BTN exit pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		Application.Quit();
		Debug.Log("Btn exit Released");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
