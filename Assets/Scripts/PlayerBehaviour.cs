using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public float speed = 0.5f;
    public GameObject Bullet;
    public GameScript GenerateEnemy;
    public HealthScript healthScript;
    public WeaponScript weapon;



	// Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    private int const_rand = 1, rand;
    void Update()
    {

        float move = Input.GetAxis("Horizontal");

        float jump = Input.GetAxis("Vertical");

        gameObject.transform.position += new Vector3(move * speed, jump * speed, 0);

        if (gameObject.transform.position.x < -38)
        {
            gameObject.transform.position = new Vector3(-38, gameObject.transform.position.y, 0);
        }

        if (gameObject.transform.position.x > 38)
        {
            gameObject.transform.position = new Vector3(38, gameObject.transform.position.y, 0);
        }

        if (gameObject.transform.position.y < -23)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -23, 0);
        }

        if (gameObject.transform.position.y > 23)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 23, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            weapon.Attack(false);
        }

        rand = Random.Range(1, 100);

        if (const_rand == rand)
        {
            GenerateEnemy.Generate(true);
        }

        rand = Random.Range(1, 200);

        if (const_rand == rand)
        {
            GenerateEnemy.GenerateMeteorite();
        }

        //rand = Random.Range(1, 250);

        //if (const_rand == rand)
        //{
        //    GenerateEnemy.GenerateNagibator();
        //}


    }

}
