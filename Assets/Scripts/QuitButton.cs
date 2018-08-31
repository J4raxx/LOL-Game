using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    private void OnMouseDown()
    {
        SceneManager.LoadScene("MainMenu");
    }

	// Update is called once per frame
	void Update () {
		
	}
}
