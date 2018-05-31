using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class BtnRotate : MonoBehaviour, IVirtualButtonEventHandler {
	public GameObject vbBtnObj;
	public Animator sweater;

	// Use this for initialization
	void Start () {
		vbBtnObj = GameObject.Find("RotateBtn");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		sweater.GetComponent<Animator>();
		sweater.speed = 0.2f;
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){
		sweater.Play("sw_rotate"); 
		Debug.Log("BTN pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		sweater.Play("none"); 
		Debug.Log("Btn Released");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
