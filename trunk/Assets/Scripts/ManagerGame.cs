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

	void Start () 
	{
		UIInstance = this;
		
		score = 0;
		gametime = 20;

	}

	void Update () 
	{
		ScoreText.text = "Score:" + score ;
		GameTimeText.text = "Time:" + gametime; 
		//Essas duas linhas sao para mostrar que os valores na tela do game estao mudando
		gametime --;
		score ++;
	}

	/*void OnGui()//Com a UI, nao precisamos usar a void OnGui e coisas relacionadas; 90% do que e exibido na tela pro player e feito no editor da Unity, os outros 10% sao script para mudar valores.
	{
		//GUI.Label (new Rect (Screen.width * 1f, Screen.height * 0.95, 50, 15), "Score: " + score);
		Debug.Log ("GUIOK");
	}*/
}
