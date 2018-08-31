using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitbuttom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseDown()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
	}
}
