using UnityEngine;
using System.Collections;

public class StarSpawn : MonoBehaviour 
{
	public GameObject Star;
	public float maxPos = 4.5f;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame	
	void Update()
	{
		InvokeRepeating ("Spawn", 1.0f, 1.0f);
		
	}
	
	void Spawn ()
	{
		float y = Random.Range (-4.4f, 4.4f);
		Vector3 StarPos = new Vector3 (this.transform.position.x, y, this.transform.position.z);
		//Vector3 meteorPos = new Vector3 (Random.Range(-4.4f,4.4f),transform.position.y , transform.position.z);
		
		Instantiate (Star, StarPos, transform.rotation);
		CancelInvoke();
	}
}