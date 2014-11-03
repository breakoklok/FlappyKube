using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject rocks;
	
	//TODO: Rewrite obstacle generator to a coroutine.
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	
	// Update is called once per frame
	
	
	void CreateObstacle()
	{
		//float temp = Random.value;
		rocks.transform.localScale = new Vector3(Random.value+0.3f,1,1);
		rocks.transform.localPosition = new Vector3 (10,rocks.transform.localPosition.y,rocks.transform.localPosition.z);

		Instantiate(rocks);
	}
}