using UnityEngine;
using System.Collections;

public class CharacterSpawner : MonoBehaviour {
	public static GameObject selectedCharacter;
	
	public GameObject character1; // drag character prefabs here in the inspector
	public GameObject character2;
	public GameObject character3;
	public GameObject character4;
	
	public int savedPlayer = 0;
	
	void Awake ()
	{
		savedPlayer = PlayerPrefs.GetInt ("selectedPlayer");
		
		character1 = GameObject.Find ("Player01");
		character2 = GameObject.Find ("Player02");
		character3 = GameObject.Find ("Player03");
		character4 = GameObject.Find ("Player04");
		
		
		if (savedPlayer == 0) { // geen character gekozen
			character1.SetActive (true);
			character2.SetActive (false);
			character3.SetActive (false);
			character4.SetActive (false);
		} 
		
		else if (savedPlayer == 1) 
		{
			character1.SetActive(true);
			character2.SetActive(false);
			character3.SetActive(false);
			character4.SetActive(false);
		}
		
		else if (savedPlayer == 2) 
		{
			character2.SetActive(true);
			character1.SetActive(false);
			character3.SetActive(false);
			character4.SetActive(false);
		}
		
		else if (savedPlayer == 3) 
		{
			character3.SetActive(true);
			character1.SetActive(false);
			character2.SetActive(false);
			character4.SetActive(false);
		}
		
		else if (savedPlayer == 4) 
		{
			character4.SetActive(true);
			character1.SetActive(false);
			character2.SetActive(false);
			character3.SetActive(false);
		}
		
	}
}