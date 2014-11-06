using UnityEngine;
using System.Collections;

public class TouchDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.touchCount != 0) 
		{
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position), Vector2.zero);
			if (hit.collider) 
			{ 
				if (hit.collider == this.gameObject.collider2D) 
				{
					Application.LoadLevel (1);
				}
			}
		}
	}
}
