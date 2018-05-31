using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Diseños : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vButton;
    public GameObject vButton1;
    public GameObject vButton2;
    public GameObject vButton3;

    // Use this for initialization
    void Start()
    {
        vButton = GameObject.Find("Design");
        vButton1 = GameObject.Find("Image");
        vButton2 = GameObject.Find("Text");
        vButton3 = GameObject.Find("Edit");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vButton1.transform.Translate(-2, 1, 1);
        vButton2.transform.Translate(-2, 1, 1);
        vButton3.transform.Translate(-2, 1, 1);

        Debug.Log("Press Design");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

 
	
	// Update is called once per frame
	void Update () {
		
	}
}
