using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FuncionNegro : MonoBehaviour, IVirtualButtonEventHandler{
	
	public Negro _Negro;
    public GameObject vButton;
 // Use this for initialization
    void Start()
    {

        vButton = GameObject.Find("Black");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _Negro.SwapTexture();

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        _Negro.SwapTexture();
        Debug.Log("Press Yellow");
    }

   

}
