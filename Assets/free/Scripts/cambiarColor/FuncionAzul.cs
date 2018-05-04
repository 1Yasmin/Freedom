using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FuncionAzul : MonoBehaviour, IVirtualButtonEventHandler{
	
	public Azul _Azul;
    public GameObject vButton;
 // Use this for initialization
    void Start()
    {

        vButton = GameObject.Find("Blue");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _Azul.SwapTexture();

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        _Azul.SwapTexture();
        Debug.Log("Press Blue");
    }

   

}
