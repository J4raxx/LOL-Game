using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchHP : MonoBehaviour {

    // Use this for initialization

    public HealthScript healthScript;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "HPPoint")
        {
            healthScript.HP += 20;
            if (healthScript.HP > 200)
            {
                healthScript.HP = 200;
            }
            Destroy(collision.gameObject);
            //Debug.Log("###############");
        }
    }
}
