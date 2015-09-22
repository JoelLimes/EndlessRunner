using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	

	public float maxSpeed = 12f;
	public string idleAnimation = "IchiIdle";
	public string moveAnimation = "IchiMove";
	public string attackAnimation01 = "IchiAttack01";
	public string attackAnimation02 = "IchiAttack02";
	public string jumpAnimation = "IchiJump";

	
	//animation States
	
	
	Animator anim;
	
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	void Update () 
	{
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * 20f * Time.deltaTime);
			anim.Play(moveAnimation);
			
		} else if (Input.GetKey (KeyCode.Z)) {
			//			transform.Translate (-Vector2.right * 30f * Time.deltaTime);
			anim.Play(attackAnimation01);
			
		} else if (Input.GetKey (KeyCode.X)) {
			//			transform.Translate (Vector2.up * 17f * Time.deltaTime);
			anim.Play(attackAnimation02);
		}
		
		else if (Input.GetKey (KeyCode.Space)) {
			transform.Translate (Vector2.up * 7.5f * Time.deltaTime);
			
			anim.Play (jumpAnimation);
		}
		
		else {
			anim.Play (idleAnimation);
		}	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Collectables") {
			Destroy (other.gameObject);
			StarManager.starsToAdd++;
			StarManager.addStars (StarManager.starsToAdd);
			StarManager.starsToAdd = 0;

		}
	}
}