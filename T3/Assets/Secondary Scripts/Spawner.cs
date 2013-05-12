using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject m_Enemy;
    public GameObject m_spawnPoint;
    public float m_spawnRate;
    private float m_spawnTimer;
    //public GameObject m_powerUp;
   // public int m_upgradeShip;
    //private int m_shipCounter = 0;


	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        if (m_spawnTimer < 0){
            Spawn();
        }else{
            m_spawnTimer = m_spawnTimer - Time.deltaTime;
        }

	}
    public void Spawn(){
        Spawn(m_Enemy);
    }
    public void Spawn(GameObject spawnObject)
    {
        GameObject go = (GameObject)Instantiate(spawnObject, m_spawnPoint.transform.position, Quaternion.identity);
        m_spawnTimer = m_spawnRate;
        
    }
}
