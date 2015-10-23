using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ManagerEnemy : MonoBehaviour 
{	
	private Transform EnemyTransf;

	public List<GameObject> Enemies;

	// Use this for initialization
	void Start () 
	{
	
		EnemyTransf = GetComponent<Transform>();

		Enemies = new List<GameObject>();

	}

	// Update is called once per frame
	void Update () 
	{
	
		EnemyTransf.Translate(new Vector3(0,-0.12f,0));
		//return "enemydown";

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		// Colisao por tag com os colisores adicionais dos " enemies" para somar pontos a mais.
		switch (other.gameObject.tag) 
		{
		case "Limite":

			transform.position = new Vector3(0.27f,10.19f, 0);
			print(transform.position.y);

			Debug.Log("BateuAquiOlha");
			
			break;
		}
	}
}
