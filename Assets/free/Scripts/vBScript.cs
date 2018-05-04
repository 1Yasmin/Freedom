using System.Collections;
using UnityEngine;
using Vuforia;

public class vBScript: MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vButton;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
        
        vButton = GameObject.Find("actionButton");
        
        
		
	}

}
