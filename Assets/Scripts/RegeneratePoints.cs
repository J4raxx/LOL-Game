using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegeneratePoints : MonoBehaviour 
{
    public GameObject HPPointPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    public WeaponScript weapon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "HPPointTrigger")
        {
            //if (Input.GetKeyDown(KeyCode.LeftControl))
                //weapon.Attack(false);
            Random rand = new Random();

            int x, y;

            x = Random.Range(-10, 10);

            y = Random.Range(10, 20);

            Instantiate(HPPointPrefab, HPPointPrefab.transform.position + new Vector3(x, y, 0), Quaternion.Euler(0, 0, 0));
        }

    }
}
