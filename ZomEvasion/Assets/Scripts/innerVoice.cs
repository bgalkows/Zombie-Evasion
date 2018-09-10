using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class innerVoice : MonoBehaviour {
    public AudioClip whatHappened;
    public AudioClip goodLandingArea;

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = whatHappened;
        StartCoroutine("startVoice");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator startVoice()
    {
        yield return new WaitForSeconds(1.75f);
        audioSource.Play();
    }

    void OnFindClearArea()
    {
        print(name + " OnFindClearArea");
        audioSource.clip = goodLandingArea;
        audioSource.Play();

        Invoke("CallHeli", goodLandingArea.length + 1f);
    }

    void CallHeli()
    {
        SendMessageUpwards("OnMakeInitialHeliCall");
    }
}
