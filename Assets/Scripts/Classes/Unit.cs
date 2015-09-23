using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{
    public float health;
    protected bool facingRight;
    protected int dir;
    public float movementSpeed;
    public float jumpForce;
    protected bool canJump;


    // Use this for initialization
    void Start ()
    {
        
	}

    protected void Movement()
    {
        Vector2 movement = new Vector2(movementSpeed, 0) * dir * Time.deltaTime;
        transform.Translate(movement);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            Destroy(other.gameObject);
            StarManager.starsToAdd++;
            StarManager.addStars(StarManager.starsToAdd);
            StarManager.starsToAdd = 0;

        }

        if(other.gameObject.tag == "Obstacle")
        {
            health -= 1;
            Debug.Log(health);
        }
    }
}
