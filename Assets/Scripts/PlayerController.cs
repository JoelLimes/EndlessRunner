using UnityEngine;
using System.Collections;

public class PlayerController : Unit
{

    private Rigidbody2D rb;


    public float maxSpeed = 12f;
    private Vector2 endOfScreen = new Vector2(20, 0);
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
<<<<<<< HEAD
        rb = GetComponent<Rigidbody2D>();
    }

    protected void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void PlayerInput()
    {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            dir = 1;
            Movement();
            //transform.Translate (Vector2.right * 20f * Time.deltaTime);
            anim.Play(moveAnimation);
=======
	}
	
	void Update () 
	{
		
//		if (Input.GetKey (KeyCode.RightArrow)) {
//			transform.Translate (Vector2.right * 20f * Time.deltaTime);
//			anim.Play(moveAnimation);
//			
//		} 
		if (Input.GetKey (KeyCode.Z)) {
			//			transform.Translate (-Vector2.right * 30f * Time.deltaTime);
			anim.Play(attackAnimation01);
			
		} else if (Input.GetKey (KeyCode.X)) {
			//			transform.Translate (Vector2.up * 17f * Time.deltaTime);
			anim.Play(attackAnimation02);
		}
		
		else if (Input.GetKey (KeyCode.Space)) {
			transform.Translate (Vector2.up * 8.5f * Time.deltaTime);
			
			anim.Play (jumpAnimation);
		}
		
		else {
			anim.Play (moveAnimation);
			transform.Translate (Vector2.right * 20f * Time.deltaTime);
		}	
	}
>>>>>>> origin/master

        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            dir = -1;
            Movement();
            //transform.Translate (Vector2.right * 20f * Time.deltaTime);
            anim.Play(moveAnimation);

        }

        if (Input.GetKey(KeyCode.Z))
        {
            //			transform.Translate (-Vector2.right * 30f * Time.deltaTime);
            anim.Play(attackAnimation01);
        }

        if (Input.GetKey(KeyCode.X))
        {
            //			transform.Translate (Vector2.up * 17f * Time.deltaTime);
            anim.Play(attackAnimation02);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Translate (Vector2.up * 7.5f * Time.deltaTime);
            if (canJump)
            {
                Jump();
                canJump = false;
                print(canJump);
            }

            anim.Play(jumpAnimation);
        }
        else
        {
            anim.Play(idleAnimation);
        }

        if (this.transform.position.x >= 19)
        {
            transform.position = new Vector2(19, transform.position.y);
        }
        else if (this.transform.position.x <= -5)
        {
            transform.position = new Vector2(-5, transform.position.y);
        }
    }

    void Update () 
	{
        PlayerInput();
	}

}