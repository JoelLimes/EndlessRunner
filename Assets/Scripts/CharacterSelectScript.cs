using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelectScript : MonoBehaviour {

	public int selectedPlayer = 0;

	Camera camera;

	void Start()
	{
		camera = GetComponent<Camera>();
	}

	void Update ()
	{
		if (Input.GetMouseButtonUp (0)) 
		{
//			Ray ray = camera.main.ScreenPointToRay(Input.mousePosition);
		}
	}
}