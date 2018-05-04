using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FuncionNaranja : MonoBehaviour, IVirtualButtonEventHandler{
	
	public Naranja _Naranja;
    public GameObject vButton;
 // Use this for initialization
    void Start()
    {

        vButton = GameObject.Find("Orange");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _Naranja.SwapTexture();

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        _Naranja.SwapTexture();
        Debug.Log("Press Orange");
    }

   

}
