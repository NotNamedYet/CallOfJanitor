using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : NetworkBehaviour {

    public FirstPersonController controller;
    public Camera fpscamera;
    public AudioListener audiolistener;

	// Use this for initialization
	void Start ()
    {
	    if (!isLocalPlayer)
        {
            controller.enabled = false;
            fpscamera.enabled = false;
            audiolistener.enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
