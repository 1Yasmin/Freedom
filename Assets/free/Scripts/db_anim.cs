using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class db_anim : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObj;
	public Animator cubeAni;

	// Use this for initialization
	void Start () {
		vbBtnObj = GameObject.Find("BtnAnim"); 
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		cubeAni.GetComponent<Animator>();
	}
	
	public void OnButtonPressed(VirtualButtonBehaviour vb){
		cubeAni.Play("sw_rotate"); 
		Debug.Log("Btn Pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		cubeAni.Play("none"); 
		Debug.Log("Btn Released");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
