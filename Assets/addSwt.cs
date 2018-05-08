using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class addSwt : MonoBehaviour, IVirtualButtonEventHandler {
	public GameObject gt;
	public GameObject vbBtnObj;

	// Use this for initialization
	void Start () {
		vbBtnObj = GameObject.Find("Add");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		gt = GameObject.Find("Cube_001");
		gt.gameObject.SetActive(false);
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){ 
		Debug.Log("BTN Add pressed");
		gt.gameObject.SetActive(true);
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		Debug.Log("Btn Add Released");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
