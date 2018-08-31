using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public GameObject Camera;

    public GameObject Enemy;

    public GameObject HPPointPrefab;

    public GameObject CoinPrefab;

    public GameObject Player;

    public GameObject MeteoritePrefab;

    public Transform EnemyPrefab;

    public Transform NagibatorPrefab;

    public HealthScript healthScript;

    public CoinsScript coinsScript;

    private int time;

    private float score;

    public float x, y;

    private int r = 50;

	void Start () {
		
	}

	void Update () 
    {
        int hpr = Random.Range(0, 250);
        if (r == hpr)
        {
            Random rand = new Random();

            int x, y;

            x = Random.Range(-39, 39);

            y = Random.Range(-21, 4);

            Instantiate(HPPointPrefab, new Vector3(x, y, 0), Quaternion.Euler(0, 0, 0));
        }

        int cr = Random.Range(0, 700);

        if (r == cr)
        {
            Random rand = new Random();

            int x, y;

            x = Random.Range(-39, 39);

            y = Random.Range(-21, 4);

            Instantiate(CoinPrefab, new Vector3(x, y, 0), Quaternion.Euler(0, 0, 0));
        }
        score += Time.deltaTime;
            
	}
    private int hr = 50;

    public void GenerateSquare()
    {

        Debug.Log("CHECK");

        var EnemyTransform = EnemyPrefab as Transform;

        EnemyTransform.position = transform.position;

        EnemyBehaviour enemy = EnemyTransform.gameObject.GetComponent<EnemyBehaviour>();

        enemy.transform.position += new Vector3(0, 0, 0);

        Instantiate(enemy, enemy.transform.position + new Vector3(-10, y + 60, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(0, y + 60, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(10, y + 60, 0), Quaternion.Euler(0, 0, 0));



        Instantiate(enemy, enemy.transform.position + new Vector3(-10, y + 55, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(0, y + 55, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(10, y + 55, 0), Quaternion.Euler(0, 0, 0));



        Instantiate(enemy, enemy.transform.position + new Vector3(-10, y + 50, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(0, y + 50, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(10, y + 50, 0), Quaternion.Euler(0, 0, 0));
    }

    public void GenerateTriangle()
    {
        
        var EnemyTransform = EnemyPrefab as Transform;

        EnemyTransform.position = transform.position;

        EnemyBehaviour enemy = EnemyTransform.gameObject.GetComponent<EnemyBehaviour>();

        enemy.transform.position += new Vector3(0, 0, 0);

        Instantiate(enemy, enemy.transform.position + new Vector3(-10, y + 60, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(0, y + 60, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(10, y + 60, 0), Quaternion.Euler(0, 0, 0));



        Instantiate(enemy, enemy.transform.position + new Vector3(-5, y + 55, 0), Quaternion.Euler(0, 0, 0));

        Instantiate(enemy, enemy.transform.position + new Vector3(5, y + 55, 0), Quaternion.Euler(0, 0, 0));



        Instantiate(enemy, enemy.transform.position + new Vector3(0, y + 50, 0), Quaternion.Euler(0, 0, 0));

    }

    public void Generate(bool AreEnemiesDead)
    {
        
        //Random rand = new Random();

        int type = Random.Range(1, 7);

        //int type = Random.Range(4, 5);

        if (type == 2)
        {
            GenerateSquare();
            return;
        }

        if (type == 3)
        {
            GenerateTriangle();
            return;
        }

        if (type == 4 || type == 5)
        {
            x = Player.transform.position.x;

            y = Player.transform.position.y;

            var NagibatorTransform = NagibatorPrefab as Transform;

            NagibatorTransform.position = transform.position;

            NagibatorBehaviour nagibator = NagibatorTransform.gameObject.GetComponent<NagibatorBehaviour>();

            nagibator.transform.position += new Vector3(0, 0, 0);

            Instantiate(nagibator, nagibator.transform.position + new Vector3(x, y + 50, 0), Quaternion.Euler(0, 0, 0));

            return;
        }

        x = Player.transform.position.x;

        y = Player.transform.position.y;          

        var EnemyTransform = EnemyPrefab as Transform;
           
        EnemyTransform.position = transform.position;

        EnemyBehaviour enemy = EnemyTransform.gameObject.GetComponent<EnemyBehaviour>();

        enemy.transform.position += new Vector3(0, 0, 0);

        Instantiate(enemy, enemy.transform.position + new Vector3(x, y + 50, 0), Quaternion.Euler(0, 0, 0));

    }

    public void GenerateMeteorite()
    {
        x = Player.transform.position.x;

        y = Player.transform.position.y;

        var EnemyTransform = EnemyPrefab as Transform;

        Instantiate(MeteoritePrefab, MeteoritePrefab.transform.position + new Vector3(x, y + 50, 0), Quaternion.Euler(0, 0, 0));
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 50, 150, 150), "Score: " + Mathf.Round(score));
        GUI.Label(new Rect(100, 30, 150, 150), "Health: " + healthScript.HP);
        Debug.Log("COINS");
        GUI.Label(new Rect(100, 10, 150, 150), "Coins: " + coinsScript.AmountCoins);
    }

    //public void GenerateNagibator(bool AreEnemiesDead)
    //{

    //    Random rand = new Random();

    //    int type = Random.Range(1, 2);

    //    x = Player.transform.position.x;

    //    y = Player.transform.position.y;

    //    var NagibatorTransform = NagibatorPrefab as Transform;

    //    NagibatorTransform.position = transform.position;

    //    NagibatorBehaviour nagibator = NagibatorTransform.gameObject.GetComponent<NagibatorBehaviour>();

    //    nagibator.transform.position += new Vector3(0, 0, 0);

    //    Instantiate(nagibator, nagibator.transform.position + new Vector3(x, y + 50, 0), Quaternion.Euler(0, 0, 0));

    //}


}
