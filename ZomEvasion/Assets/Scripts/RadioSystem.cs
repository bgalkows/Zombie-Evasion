using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    public AudioClip InitialCallReply;

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMakeInitialHeliCall()
    {
        print(name + " OnMakeInitialHeliCall");
        //audioSource.clip = initialHeliCall;
        //audioSource.Play();
        Invoke("InitialReply",1.5f);
    }

    void InitialReply()
    {
        audioSource.clip = InitialCallReply;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }


}
