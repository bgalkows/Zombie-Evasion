using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {
    public bool helicopterReady = false;
    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(helicopterReady && Vector3.Distance(this.transform.position, player.transform.position) < 3f)
        {
            UnityEngine.Cursor.visible = true;
            SceneManager.LoadScene("Victory");   
        }
	}
}
