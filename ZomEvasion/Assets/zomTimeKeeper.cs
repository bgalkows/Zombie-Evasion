using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zomTimeKeeper : MonoBehaviour {
    public float timeSinceBirth;

	// Use this for initialization
	void Awake () {
        timeSinceBirth = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceBirth += Time.deltaTime / 1.75f;
	}
}
