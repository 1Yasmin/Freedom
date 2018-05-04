using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FuncionAmarillo : MonoBehaviour, IVirtualButtonEventHandler{
	
	public Amarillo _Amarillo;
    public GameObject vButton;
 // Use this for initialization
    void Start()
    {

        vButton = GameObject.Find("Yellow");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _Amarillo.SwapTexture();

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        _Amarillo.SwapTexture();
        Debug.Log("Press Yellow");
    }

   

}
