using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManagerGame : MonoBehaviour 
{
	public static float score;
	public static float timeoff; // tempo para acrescentar pontos no score
	//public static float gametime;
	public string scene;
	public Text ScoreText; 
	//public Text GameTimeText;

	public static ManagerGame UIInstance;

	void Start () 
	{
		UIInstance = this;
		
		score = 0;
		//gametime = 20f;

	}

	void Update () 
	{
		//OnGUI via UI
		ScoreText.text = "Score:" + score;
		//GameTimeText.text = "Time:" + gametime; 
		//gametime -= Time.deltaTime;
		score += Time.deltaTime;

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		switch(other.gameObject.tag)
		{
		case "Play":
			
			Application.LoadLevel(scene);
			
			break;
		}
	}
}