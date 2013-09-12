using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
	// Use this for initialization
	public string highscoretime;
	public Timer timerscript;
	public string username = "Laza";
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		highscoretime = timerscript.time;
		PlayerPrefs.SetString("username1",username);
		PlayerPrefs.SetString("highscorelvl1",highscoretime);
	}
		
}
