using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints; // The Parent of the the Spawn Points Container
	public bool reSpawn = false; // Test Respawn Trigger

	private Transform[] spawnPoints; // Array of Spawn Points
	private bool lastToggle = false;

	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>(); //Get the Transforms of all the children spawn points
		print(spawnPoints.Length); //Print out to log the number of spawn points transforms returned (will return the parent as well)
	}
	
	// Update is called once per frame
	void Update () {
		if(lastToggle != reSpawn){
			ReSpawn();
			reSpawn = false;
		}else {
			lastToggle = reSpawn;
		}
	}

	private void ReSpawn(){
		int i = Random.Range(1, spawnPoints.Length); // Random Spawn at everything bar array value 0 which is the parent object which is not a spawn point
		transform.position = spawnPoints[i].transform.position;
	}

	void OnFindClearArea(){
		Invoke("DropFlare", 3f);
	}

	void DropFlare(){
		//Drop a Flare
	}
}
