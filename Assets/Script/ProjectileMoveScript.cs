/*using UnityEngine;
using System.Collections;

public class ProjectileMoveScript : MonoBehaviour {
	
	public Vector2 speed = new Vector2 (10, 10);

	//private Vector3 mouseX = new Vector3 (Input.mousePosition);

	//private Vector3 mouseY = new Vector3 (Input.mousePosition);


	
	public Vector2 direction = new Vector2(Cursor.Position.X, Cursor.Position.Y);
	
	// Update is called once per frame
	void Update () {

		Vector3 movement = new Vector3 (speed.x * direction.x, speed.y * direction.y, 0);
		
		movement *= Time.deltaTime;
		
		transform.Translate (movement);
		
	}
}
*/
