using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour 
{	
	private Transform transf;


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
}	
	
