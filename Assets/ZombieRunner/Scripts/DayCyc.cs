using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCyc : MonoBehaviour {

	[Tooltip("Number of Minutes Per Second That Past")]
	public float minutesPerSecond;
	
	// Update is called once per frame
	void Update () {
		float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
		transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
