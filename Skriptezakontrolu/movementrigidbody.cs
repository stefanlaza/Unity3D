using UnityEngine;
using System.Collections;
// Coded by PsiCoding Studio SL
public class movementrigidbody : MonoBehaviour {

	// Use this for initialization
	private bool grounded; 
	public int jumpspeed = 10;
	public int speed = 10;

	void Start () {
	}
	void OnCollisionEnter(Collision other)
	{
		grounded = true; // collision with any object is grounded
	}
	void OnCollisionExit(Collision other)
	{
		grounded = false; // collision exit with any object is not grounded 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (Input.GetKey (KeyCode.UpArrow) && grounded == true) // if up arrow and object is grounded
		{
			GameObject.FindGameObjectWithTag("Player").rigidbody.AddForce(Vector3.up * jumpspeed); //then find player object and move up * jumpspeed
			grounded = false;//jump		// set in air to grounded false 
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			//GameObject.FindGameObjectWithTag("Player").rigidbody.AddForce(new Vector3(-1, 0, 0), ForceMode.Impulse);//levo
			 GameObject player = GameObject.FindWithTag("Player");
        player.transform.Translate(-speed*Time.deltaTime, 0, 0); // - speed from axis * Time.deltatime so the object does not use framerate
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			
			GameObject player = GameObject.FindWithTag("Player");
        player.transform.Translate(speed*Time.deltaTime, 0, 0);
			//GameObject.FindGameObjectWithTag("Player").rigidbody.AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);//desno
		}	
	}
}
