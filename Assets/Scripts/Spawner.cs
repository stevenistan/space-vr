using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject star;
	public int numberOfStars;
	public float radius;

	// Use this for initialization
	void Start () {
		// Spawns numberOfStars in a circle around the (0, 0, 0)
		for (int i = 0; i < numberOfStars; i++) {
			float angle = i * Mathf.PI * 2 / numberOfStars;
			Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
			Instantiate(star, pos, Quaternion.identity);
		}
	}
}
