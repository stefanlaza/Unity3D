using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour {

void OnTriggerEnter (Collider other)
{
	Application.LoadLevel(Application.loadedLevel);
}
}	

