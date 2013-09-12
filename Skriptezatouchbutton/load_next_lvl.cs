using UnityEngine;
using System.Collections;

public class load_next_lvl: MonoBehaviour {
void OnTriggerEnter (Collider other)
{
	if (Application.loadedLevel + 1 < Application.levelCount)
		Application.LoadLevel(Application.loadedLevel + 1);
}
}	

