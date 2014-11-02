using UnityEngine;

public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector2(0, 300);
	int score = 0;
	
	// Update is called once per frame
	void Update ()
	{
		// Jump
		if (Input.GetKeyUp("space"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}
		
		if (Input.touchCount != 0)
		{
			var finger1 = Input.GetTouch(0);
			if (finger1.phase == TouchPhase.Began)
			{
				rigidbody2D.velocity = Vector2.zero;
				rigidbody2D.AddForce(jumpForce);
			}
		}
		
		// Die by being off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0 || screenPosition.x < 0)
		{
			Die();
		}
	}
	
	
	
	void OnGUI () 
	{
		GUI.color = Color.black;
		GUILayout.Label(" Score: " + score.ToString());
	}
	
	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
