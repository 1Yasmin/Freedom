using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FuncionVerde : MonoBehaviour, IVirtualButtonEventHandler{
	
	public Verde _Verde;
    public GameObject vButton;
 // Use this for initialization
    void Start()
    {

        vButton = GameObject.Find("Green");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _Verde.SwapTexture();

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        _Verde.SwapTexture();
        Debug.Log("Press Green");
    }

   

}
