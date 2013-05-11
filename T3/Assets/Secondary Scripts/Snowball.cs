using UnityEngine;
using System.Collections;

public class Snowball : MonoBehaviour {
	
	public int snowballsize;
	public AudioClip SnowballGetSound;
	// Use this for initialization
	public GameObject Snowballpickup;
	
	public Texture2D[] Snowballamount;
	public GUITexture snowAmountHUDGUI;
	void Start () {
	snowballsize = 30;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SnowGet()
	{
		AudioSource.PlayClipAtPoint(SnowballGetSound,transform.position);
		snowballsize++;
		snowAmountHUDGUI.texture = Snowballamount[snowballsize];
		GameObject.DestroyObject(Snowballpickup);
	}
}
