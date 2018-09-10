using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

    public float timeSinceLastTrigger = 0f;

    private bool foundClear = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastTrigger += Time.deltaTime;

        if(timeSinceLastTrigger >= 2.5f  && Time.realtimeSinceStartup > 7f && !foundClear)
        {
            SendMessageUpwards("OnFindClearArea");
            foundClear = true;
        }
        
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.tag != "Player")
        {
            timeSinceLastTrigger = 0f;
        }
    }
}
