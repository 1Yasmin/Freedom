using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FuncionBlanco : MonoBehaviour, IVirtualButtonEventHandler{
	
	public Blanco _Blanco;
    public GameObject vButton;
 // Use this for initialization
    void Start()
    {

        vButton = GameObject.Find("White");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _Blanco.SwapTexture();

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        _Blanco.SwapTexture();
        Debug.Log("Press White");
    }

   

}
