using UnityEngine;
using System.Collections;

public class Scrolling : MonoBehaviour {
    public float scrollSpeed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 moveBG = new Vector2(- scrollSpeed, 0) * Time.deltaTime;
        transform.Translate(moveBG);
    }
}
