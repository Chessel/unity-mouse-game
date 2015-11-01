using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	//sets variables for x and y 
	static int x = 1;



	//  int numEnemies = 3;

	public Vector2 up = new Vector2(0, x);
	public Vector2 down= new Vector2(0, -x);
	public Vector2 right = new Vector2(x, 0);
	public Vector2 left = new Vector2(-x, 0);


	//public Vector2 myYForce = new Vector2(0, y);



	void OnCollisionEnter2D(Collision2D col){
		/*if collision was on top force is down
		 * if collision was on bottom force is left
		 * if collision was on left force is right
		 * if collision is on right force is on top
		 * 
		 * */

		//print ("hello");
		//

		if(col.gameObject.name == "blueBlock1")
		{
			this.GetComponent<ConstantForce2D> ().force = left;
		}else if(col.gameObject.name == "blueBlock5")
		{
			this.GetComponent<ConstantForce2D> ().force = down;
		}else if(col.gameObject.name == "blueBlock4")
		{
			this.GetComponent<ConstantForce2D> ().force = right;
		}else if(col.gameObject.name == "blueBlock3")
		{
			this.GetComponent<ConstantForce2D> ().force = up;
		}

		//this.GetComponent<ConstantForce2D> ().force =  myForce;

	}




	// Use this for initialization
	void Start () {

	}


	
	// Update is called once per frame
	void Update () {
		//if (myForce [0] == 0) {
			//this.GetComponent<ConstantForce2D> ().force = new Vector2 (-1, 0);
			
		//}

	}
}

		//if(this.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0))
		//this.transform.Translate (x, y, z);
		//y++;

		//Transform movement = this.GetComponent<Transform>();
		//Vector2 vel = Vector2(0,0);

		//if (movement) {
			//Vector3 newPosition = this.transform.position;
			//newPosition.y = y++;
			//this.transform.position = newPosition;
		//}

	