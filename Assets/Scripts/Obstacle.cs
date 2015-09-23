using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
    public float minspeed, maxSpeed;
    private float currentSpeed;
    private Rigidbody2D rb;


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = Random.Range(minspeed, maxSpeed);
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.velocity = Vector2.up * -currentSpeed;

        if (this.transform.position.y <= -6)
        {
            Destroy(this.gameObject);
        }
	}
}
