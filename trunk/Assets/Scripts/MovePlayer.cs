using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour 
{	
	private static Transform transf;
	public string scene;


	// Use this for initialization
	void Start () 
	{
		transf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log(move());
	}

	private string move()
	{ 
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transf.Translate(new Vector3(-0.2f, 0, 0));
			return "LEFT";
		}
		else if(Input.GetKey(KeyCode.RightArrow))
		{
			transf.Translate(new Vector3(0.2f, -0, 0));
			return "RIGHT";
		}
		else
		{
			transf.Translate(new Vector3(0f, 0.001f, 0));
			return "UP";
			//return "IDLE";
		}
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		// Colisao por tag com os colisores adicionais dos " enemies" para somar pontos a mais.
		switch(other.gameObject.tag)
		{
		case "NaoBateu":

			ManagerGame.score += 50;
			//gametime += 20f;
			
			break;
			
		case "Bateu" :
			
			Application.LoadLevel(scene);
			
			break;
			
		}
		
	}

}	
	
