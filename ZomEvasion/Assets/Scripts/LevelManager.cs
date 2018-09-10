using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quit()
    {
        Application.Quit();
    }
}
