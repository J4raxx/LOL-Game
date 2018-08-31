using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

    public Transform shotPrefab;
    public float ShootingRange = 0.25f;
    private float ShootCooldown;


    // Use this for initialization
    void Start()
    {
        ShootCooldown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (ShootCooldown > 0)
            ShootCooldown -= Time.deltaTime;
    }

    public void Attack(bool IsEnemy)
    {
        if (CanAttack)
        {
            ShootCooldown = ShootingRange;

            var ShotTranform = Instantiate(shotPrefab) as Transform;

            ShotTranform.position = transform.position;

            BulletBehaviour Bullet = ShotTranform.gameObject.gameObject.GetComponent<BulletBehaviour>();

            if (Bullet != null)
            {
                Bullet.IsEnemyShot = IsEnemy;
            }

            MovementScript move = ShotTranform.gameObject.GetComponent<MovementScript>();
            if (move != null)
            {
                move.speed.x = 50;
                move.speed.y = 50;
                if (gameObject.tag == "enemy")
                {
                    move.direction = new Vector2(0, -1);
                }
                else
                    move.direction = new Vector2(0, 1);
            }
        }
    }
    public bool CanAttack
    {
        get
        {
            return ShootCooldown <= 0f;
        }
    }
}
