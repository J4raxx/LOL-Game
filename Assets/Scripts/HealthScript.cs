using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public int HP = 1;
    public bool IsEnemy = true;
    private GameScript Score;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
            Destroy(gameObject);
    }

    public void Damage(int damage)
    {
        HP -= damage;
        if (HP <= 0)
            Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        BulletBehaviour shot = collision.gameObject.GetComponent<BulletBehaviour>();
        if (shot != null)
            if (shot.IsEnemyShot != IsEnemy)
            {
                Damage(shot.damage);

                Destroy(shot.gameObject);

                //Score.kills ++;

                
            }
    }
}
