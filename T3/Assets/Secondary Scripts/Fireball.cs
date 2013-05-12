using UnityEngine;
using System.Collections;

public class Fireball :Trap {

    public GameObject Spawner;
    public Vector3 direction;
    public float speed;
    public float lifetime;
    private float spawntimer = 0;
    
    void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        spawntimer += Time.deltaTime;
        rigidbody.MovePosition(direction);
        if (lifetime > spawntimer)
        {
            float d = speed * Time.deltaTime;
            transform.rigidbody.MovePosition(transform.position + (direction * d));
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
