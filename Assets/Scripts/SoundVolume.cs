using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVolume : MonoBehaviour {

    private bool VolumeT = true;
    public int Volume = 100;

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseDown()
    {
        if (VolumeT == true)
        {
            VolumeT = false;
            AudioListener.volume = 0;
        }
        else
        {
            VolumeT = true;
            AudioListener.volume = 1;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
