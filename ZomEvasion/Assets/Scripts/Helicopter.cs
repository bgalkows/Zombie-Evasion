using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    private bool called = false;
    private Rigidbody rigidbodyM;
    private bool sound2Enabled = false;
    private Transform calledLocation;
    private Vector3 aboveTarget;
    private bool hoveringAboveTarget = false;
    private WinCondition flareWin;

    public AudioSource audioSource;
    public Player playerScript;

	// Use this for initialization
	void Start () {
        rigidbodyM = gameObject.GetComponent<Rigidbody>();
        audioSource = gameObject.GetComponent<AudioSource>();
        

	}
	
	// Update is called once per frame
	void Update () {
        if(called)
        {
            if (transform.position != aboveTarget && !hoveringAboveTarget)
            {
                transform.position = Vector3.MoveTowards(transform.position, aboveTarget, 50 * Time.deltaTime);
            }
            else if (transform.position == aboveTarget  && !hoveringAboveTarget)
            {
                audioSource.enabled = true;
                hoveringAboveTarget = true;
                Invoke("winSet", 15f);
            }
            else if (hoveringAboveTarget)
            {
                transform.position = Vector3.MoveTowards(transform.position, calledLocation.position, 10 * Time.deltaTime);
            }
        }
        
	}

    public void OnDispatchHelicopter()
    {
            //calledLocation = playerScript.transform;

            Debug.Log("Helicopter called");
            calledLocation = GameObject.FindGameObjectWithTag("Finish").transform;
            flareWin = GameObject.FindGameObjectWithTag("GameController").GetComponent<WinCondition>(); 
            aboveTarget = new Vector3(calledLocation.position.x, calledLocation.position.y + 150f, calledLocation.position.z);
            called = true;
    }

    void winSet()
    {
        flareWin.helicopterReady = true;
    }





}
