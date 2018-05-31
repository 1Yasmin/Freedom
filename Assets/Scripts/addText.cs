using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class addText : MonoBehaviour, IVirtualButtonEventHandler {
	public GameObject prefabSw; 
	public GameObject vbBtnObj;
	public GameObject swetBf;

	// Use this for initialization
	void Start () {
		vbBtnObj = GameObject.Find("Text");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){
		Destroy(swetBf);
		Debug.Log("Destroyed");
		GameObject sweater = (GameObject) Instantiate(prefabSw);
		Debug.Log("BTNText pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		Debug.Log("BtnText Released");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

