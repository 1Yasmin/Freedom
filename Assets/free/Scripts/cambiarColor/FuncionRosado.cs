using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FuncionRosado : MonoBehaviour, IVirtualButtonEventHandler{
	
	public Rosado _Rosado;
    public GameObject vButton;
 // Use this for initialization
    void Start()
    {

        vButton = GameObject.Find("Pink");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _Rosado.SwapTexture();

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        _Rosado.SwapTexture();
        Debug.Log("Press Pink");
    }

   

}
