using UnityEngine;
using System.Collections;


public class Collectables : MonoBehaviour 
{

	private int starsToAdd;
	private float speed = 5f;
	float time = 0;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (new Vector3(-1,0,0) * speed * Time.deltaTime);
		
		deleteAfterTime ();

	}

	void deleteAfterTime() {

		time += Time.deltaTime;
		
		if(time >= 5.0f) {
			Destroy(this.gameObject);
		}
	}
}