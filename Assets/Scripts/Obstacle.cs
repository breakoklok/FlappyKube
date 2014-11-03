using UnityEngine;

public class Obstacle : MonoBehaviour
{
	public GameObject playerObject;

	public Vector2 velocity = new Vector2(-4, 0);
	public float range = 4;
	// Use this for initialization
	void Start()
	{
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
		//rigidbody2D.velocity+=new Vector2 (-(playerObject.GetComponent<Player>().acceler)/*-(0.5f)*/,0);
	}
	void Update()
	{

	}
}