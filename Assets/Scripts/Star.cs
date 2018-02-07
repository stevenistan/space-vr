using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour {

	public GameObject spawner;
	public float speed;
    public Vector3 rotation;
    public RawImage img;

    void Update () {
        this.transform.RotateAround(spawner.transform.position, rotation, speed * Time.deltaTime);
    }

    void DisplayImage() {
    	img.enabled = true;
    }
}
