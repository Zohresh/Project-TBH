using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	public int damage = 1;

	public bool isEnemyShot = false;

	public int despawn = 5;

	
	// Update is called once per frame
	void Start () {

		Destroy (gameObject, despawn);
	
	}
}
