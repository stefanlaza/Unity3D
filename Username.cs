using UnityEngine;
using System.Collections;

public class Username : MonoBehaviour {

	// Use this for initialization
	public string usernamescene;
	public string highscoreplayer;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	usernamescene = PlayerPrefs.GetString("username1");
	highscoreplayer = PlayerPrefs.GetString("highscorelvl1");
	guiText.text = "Player: " + usernamescene + " " + highscoreplayer;
		
	}
}
