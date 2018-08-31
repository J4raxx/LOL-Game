using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

    public GameObject Player;
    public GameObject ExitButton;
    public GameObject RetryButton;
    public GameObject FailBackground;
    public GameObject NormalTrack;
    public GameObject FailTrack;
    public GameObject Explosion;

	// Use this for initialization
    void Start () {
        Explosion.SetActive(false);
        FailTrack.SetActive(false);
        ExitButton.SetActive(false);
        RetryButton.SetActive(false);
        FailBackground.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Player == null)
        {
            Explosion.SetActive(true);
            NormalTrack.SetActive(false);
            FailTrack.SetActive(true);
            ExitButton.SetActive(true);
            RetryButton.SetActive(true);
            FailBackground.SetActive(true);
        }
	}
}
