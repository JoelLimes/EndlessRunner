using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private int maxObs = 3;
    private Vector2 randompos;// = new Vector2(Random.Range(0,10),0);

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(ObstacleSpawn());
	}

    IEnumerator ObstacleSpawn()
    {
        while(true)
        {
            for (int i = 0; i < maxObs; i++)
            {
                randompos = new Vector2(Random.Range(-4, 20), 5);
                Instantiate(obj, randompos, Quaternion.identity);
               
                
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
}
