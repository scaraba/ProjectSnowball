using UnityEngine;
using System.Collections;

public class Snowball : MonoBehaviour {
	
	
	public AudioClip SnowballGetSound;
	// Use this for initialization
	public GameObject Snowballpickup;
   
	//public Texture2D[] Snowballamount;
	//public GUITexture snowAmountHUDGUI;

   // public float snowballsize;
    public float timetoZero;
    public string killScreen;
    private float totalTime = 0;
    private float scaleFactor;



	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        totalTime += Time.deltaTime;
        scaleFactor = (timetoZero - totalTime)/timetoZero;
        transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        if (totalTime > timetoZero)
        {
            Application.LoadLevel(killScreen);
        }
       
    }
	//IF SNOWBALL = 0 GAME OVER;

	public void SnowGet()
	{
		AudioSource.PlayClipAtPoint(SnowballGetSound,transform.position);
		//snowballsize++;
		//snowAmountHUDGUI.texture = Snowballamount[snowballsize];
		GameObject.DestroyObject(Snowballpickup);
	}

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "PowerUp")
        {
            totalTime =- 15;
            Destroy(other.gameObject);
        }
       
    
    }
}
