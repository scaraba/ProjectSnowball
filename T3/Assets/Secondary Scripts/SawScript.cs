using UnityEngine;
using System.Collections;

public class SawScript : MonoBehaviour {
    
    public Transform maxLimX1;
    public Transform maxLimX2;
    public float speed;
    public float rotSpeed;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (transform.position.x < maxLimX1.position.x)
        {
            Vector3 newPos = transform.position;
            newPos.x = maxLimX2.position.x;
            transform.position = newPos;
        }
        //transform.Rotate(transform.forward, rotSpeed * Time.deltaTime);
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

	}
}
