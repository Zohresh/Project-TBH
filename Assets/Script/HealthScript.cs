using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp =2;

	public bool isEnemy = true;

	void OnTriggerEnter2D (Collider2D collider) {

		ShotScript Shot = collider.gameObject.GetComponent<ShotScript> ();

		if (Shot != null) {

						if (Shot.isEnemyShot != isEnemy) {

								hp -= Shot.damage; 

								Destroy (Shot.gameObject);

								if (hp <= 0) {
					SpecialEffectsHelper.Instance.Explosion(transform.position);
					SoundEffectsHelper.Instance.MakeExplosionSound();
										Destroy (gameObject);
								}
						}
				}
	}
}
