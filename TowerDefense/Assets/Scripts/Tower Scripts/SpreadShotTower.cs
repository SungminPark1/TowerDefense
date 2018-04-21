﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadShotTower : Tower {
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (currentFireRate < 0) {
			GetTarget (gameObject);

			if (target && Vector2.Distance(gameObject.transform.position, target.transform.position) <= sightRange) {
				Fire ();
			}
		} else {
			currentFireRate -= Time.deltaTime;
		}
	}

	private void Fire() {
		Vector3 dir = target.transform.position - transform.position;

		for (int i = 0; i < 3; i++) {
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 85f - (i * 5);
			Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);

			GameObject clone = bulletPrefab;
			clone.GetComponent<Bullet> ().damage = damage;
			clone.GetComponent<Bullet> ().speed = bulletSpeed;
			clone.GetComponent<Bullet> ().life = bulletLife;

			Instantiate (clone, transform.position, Quaternion.RotateTowards (transform.rotation, q, 180));
		}

		resetFireRate ();
	}
}
