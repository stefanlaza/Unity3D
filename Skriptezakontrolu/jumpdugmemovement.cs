using UnityEngine;
using System.Collections;

public class jumpdugmemovement: MonoBehaviour {
	
	private bool grounded = true; 
	public int jumpspeed = 350;
	// Use this for initialization
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
	void Update () {
		
	if(Input.touches.Length <=0)
		{
			//some code 
		}
	else
		{
		 for(int i=0;i<Input.touchCount;i++)
			{
				if(this.guiTexture.HitTest(Input.GetTouch(i).position))
				{
					if(Input.GetTouch(i).phase == TouchPhase.Began)
					{
						
						GameObject.FindGameObjectWithTag("Player").rigidbody.AddForce(Vector3.up * jumpspeed); //then find player object and move up * jumpspeed
					    grounded = false;//jump		// set in air to grounded false 
					
					}
					
				}
				
			}
			
		}
			
	}
}