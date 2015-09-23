using UnityEngine;
using System.Collections;

public class BackgroundScrolling : MonoBehaviour
{
    public GameObject[] bgArray;
    public int bgNumber;
    private Vector2 screenSize;
    private GameObject instantiateBackground;

	// Use this for initialization
	void Start ()
    {
        screenSize = Camera.main.ViewportToWorldPoint(new Vector2(1.0f, 1.0f));
        ChangeBackground();
	}
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < bgArray.Length; i++) {
            
            if (instantiateBackground.transform.position.x <= -screenSize.x + 0.75f ) {
                bgNumber++;
                if (bgNumber == 3) {
                    bgNumber = 0;
                }
                ChangeBackground();
            }
        }
       // Debug.Log(bgNumber  + " " + bgArray.Length);
    }

    void ChangeBackground()
    {
            switch(bgNumber)
            {
            case 0:
                if (instantiateBackground != null)
                {
                    if (instantiateBackground.transform.position.x <= screenSize.x)
                    {
                        Destroy(instantiateBackground.gameObject);
                    }
                }
                instantiateBackground = Instantiate(bgArray[bgNumber].gameObject, transform.position, Quaternion.identity) as GameObject;
               
                break;

            case 1:
                if (instantiateBackground != null)
                {
                    if (instantiateBackground.transform.position.x <= screenSize.x)
                    {
                        Destroy(instantiateBackground.gameObject);
                    }
                }
                instantiateBackground = Instantiate(bgArray[bgNumber].gameObject, transform.position, Quaternion.identity) as GameObject;

                break;

            case 2:
                if (instantiateBackground != null)
                {
                    if (instantiateBackground.transform.position.x <= screenSize.x)
                    {
                        Destroy(instantiateBackground.gameObject);
                    }
                }
                instantiateBackground = Instantiate(bgArray[bgNumber].gameObject, transform.position, Quaternion.identity) as GameObject;

                break;
        }        
        
    }
}
