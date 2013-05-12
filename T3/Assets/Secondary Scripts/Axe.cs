using UnityEngine;
using System.Collections;

public class Axe : Trap {

    public float maxRotation;
    public float minRotation;
    public float rotationSpeed;
    private float currentRotX = 90;
	// Update is called once per frame
	void Update () 
    {
        if ((currentRotX > maxRotation && rotationSpeed > 0)||
            (rotationSpeed < 0 && currentRotX < minRotation))
        {
            rotationSpeed = rotationSpeed * -1;

        
        }
        Vector3 rotVec=new Vector3();
        currentRotX = currentRotX + Time.deltaTime * rotationSpeed;
        rotVec.x = currentRotX ;
        rotVec.y = -90;
        rotVec.z = -90;
        transform.rotation = Quaternion.Euler(rotVec);
        Debug.Log(currentRotX);
	
	}
}
