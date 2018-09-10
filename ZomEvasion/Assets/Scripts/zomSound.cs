using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zomSound : MonoBehaviour {
    public AudioSource[] audioSources;
    public float timeSinceLastGroan = 0f;

	// Use this for initialization
	void Start () {
        audioSources = gameObject.GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastGroan += Time.deltaTime;

        if (timeSinceLastGroan >= 5f)
        {
            audioSources[Random.Range(1, 4)].Play();
            timeSinceLastGroan = 0f;
        }
	}
}
