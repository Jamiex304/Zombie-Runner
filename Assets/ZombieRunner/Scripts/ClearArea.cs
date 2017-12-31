using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	private bool foundClearArea = false;
	
	// Update is called once per frame
	void Update () {
		timeSinceLastTrigger += Time.deltaTime;

		//If timeSinceLastTrigger is above 1 then the area is clear
		//If it drops below 1 then it is in a bad area and the 30x x 40z box is colloiding with something 
		if(timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea){
			SendMessageUpwards("OnFindClearArea");
			foundClearArea = true;
		}
	}

	void OnTriggerStay(Collider collider){
		if(collider.tag != "Player"){
			timeSinceLastTrigger = 0f;
		}
	}
}
