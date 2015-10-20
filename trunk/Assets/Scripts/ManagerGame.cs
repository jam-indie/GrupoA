using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManagerGame : MonoBehaviour 
{
	public static int score;
	public static int timeoff; // tempo para acrescentar pontos no score
	public static int gametime;

	public Text ScoreText; 
	public Text GameTimeText;

	public static ManagerGame UIInstance;

	// Use this for initialization
	void Start () 
	{

		UIInstance = this;


		score = 0;
		gametime = 20;

	}
	
	// Update is called once per frame
	void Update () 
	{

		ScoreText.text = "Score:" + score ;
		GameTimeText.text = "Time:" + gametime; 

	}

	void OnGui()
	{
//		GUI.Label (new Rect (Screen.width * 1f, Screen.height * 0.95, 50, 15), "Score: " + score);
		Debug.Log ("GUIOK");
	}
}
