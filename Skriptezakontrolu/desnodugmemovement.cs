using UnityEngine;
using System.Collections;

public class desnodugmemovement: MonoBehaviour {
	
	public int speed = 10;
	// Use this for initialization
	void Start () {
	
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
					if(Input.GetTouch(i).phase == TouchPhase.Stationary)
					{
						GameObject player = GameObject.FindWithTag("Player");
        					player.transform.Translate(speed*Time.deltaTime, 0, 0); // - speed from axis * Time.deltatime so the object does not use framerate
				}
			}
		}
			
	}
}
}