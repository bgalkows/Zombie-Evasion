using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daycycle : MonoBehaviour {

    [Tooltip("Number of minutes per second that pass, try 60")]
    public float minutesPerSecond;

	// Use this for initialization
	void Start () {
        //transform.rotation = new Quaternion(30f, -30f, 0f, this.transform.rotation.w);
	}
	
	// Update is called once per frame
	void Update () {
        float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
