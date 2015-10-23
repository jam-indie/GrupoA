using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour 
{
	public string scene;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseDown ()
	{
		
		if (this.gameObject.tag == "Play") {
			Application.LoadLevel (scene);
		}
	}
}
