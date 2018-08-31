using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagibatorBehaviour : MonoBehaviour
{


    public WeaponScript weapon;
    public GameObject Player;
    public HealthScript healthScript;
    // Use this for initialization
    void Start()
    {
        weapon = GetComponent<WeaponScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Player.gameObject.transform.position.x - gameObject.transform.position.x;

        if (Mathf.Abs(distance) <= 5f && weapon.CanAttack)
            weapon.Attack(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerBehaviour player = collision.gameObject.GetComponent<PlayerBehaviour>();
        HealthScript playerHP = collision.gameObject.GetComponent<HealthScript>();
        if (player != null)
        {
            if (collision.tag == "Player")
            {
                playerHP.HP -= 120;
                Destroy(gameObject);
            }
        }

    }

}
