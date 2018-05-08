using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class textBtn : MonoBehaviour, IVirtualButtonEventHandler {
	public TextMesh gt;
	public GameObject vbBtnObj;

	// Use this for initialization
	void Start () {
		vbBtnObj = GameObject.Find("Text");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		gt = GameObject.Find("Textito").GetComponent<TextMesh>();
		gt.gameObject.SetActive(false);
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){ 
		Debug.Log("BTN Text pressed");
		gt.gameObject.SetActive(true);
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		Debug.Log("Btn Text Released");
		foreach (char c in Input.inputString)
        {
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (gt.text.Length != 0)
                {
                    gt.text = gt.text.Substring(0, gt.text.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
                print("Entry: " + gt.text);
            }
            else
            {
                gt.text += c;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
