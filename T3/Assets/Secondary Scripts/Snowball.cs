using UnityEngine;
using System.Collections;

public class Snowball : MonoBehaviour {
	
	public AudioClip SnowballGetSound;
	// Use this for initialization
	public GameObject Snowballpickup;
   
    public float timetoZero;
    public string killScreen;
    private float totalTime = 0;
    private float scaleFactor;
	
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


    void OnGUI(){
    GUI.Label(new Rect(10,10,100,20),"Time:"+ Mathf.Round(timetoZero-totalTime));
    
    
    
    }
	

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "PowerUp")
        {
            AudioSource.PlayClipAtPoint(SnowballGetSound, transform.position);
            totalTime =- 15;
            Destroy(other.gameObject);
        }    
    
        if (other.gameObject.tag == "Trap")
        {
            
            other.gameObject.GetComponent<Trap>();
            totalTime += other.gameObject.GetComponent<Trap>().damage;

        }
    
    }

}
