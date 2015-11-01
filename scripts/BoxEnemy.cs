using UnityEngine;
using System.Collections;

public class BoxEnemy : MonoBehaviour {

	public int speed = -5;

	private int warpCount = 0;

	// Use this for initialization
	void Start () {
		//this.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, speed);
	}


	// When the enemy hits the player.

	void OnCollisionEnter2D()
	{
		// reloads the current level / scene.
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
	}


	// When the enemy hits the trigger.

	void OnTriggerEnter2D()
	{
		this.transform.Translate (0, 0, 0);
		warpCount++;
		speed -= 1;
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, speed);
	}
}
	

