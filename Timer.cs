using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float timer = 0f;
	public string time ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
     timer +=Time.deltaTime;
	 time = timer.ToString("0.00");
		guiText.text = time;
	}
}
