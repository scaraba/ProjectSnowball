using UnityEngine;
using System.Collections;

public class snowballpickup : Snowball {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

	void OnTriggerEnter(Collider sball)
	{
		if(sball.gameObject.tag != gameObject.tag)
		{
			SnowGet();
			
		}
		
	}
}
