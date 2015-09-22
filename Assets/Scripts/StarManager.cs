using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarManager : MonoBehaviour {

	public static int starsToAdd;
	public static int stars;
	
	Text text;

	
	void Start ()
	{
		text = GetComponent<Text> ();
		
		stars = 0;
		
	}
	
	void Update ()
	{
		if (stars < 1)
			stars = 0;
		
		text.text = "" + stars;
	}

	public static void addStars (int starsToAdd)
	{
		stars += starsToAdd;
		
	}
	
	public static void Reset ()
	{
		stars = 0;
	}
}