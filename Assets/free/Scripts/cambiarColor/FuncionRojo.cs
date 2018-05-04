using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FuncionRojo : MonoBehaviour, IVirtualButtonEventHandler{
	
	public Rojo _Rojo;
    public GameObject vButton;
 // Use this for initialization
    void Start()
    {

        vButton = GameObject.Find("Red");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _Rojo.SwapTexture();

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        _Rojo.SwapTexture();
        Debug.Log("Press Red");
    }

   

}
