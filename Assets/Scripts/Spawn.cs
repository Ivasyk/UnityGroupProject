using System;
using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public bool ded;
	public GameObject spawnpoint;
	// Use this for initialization
	void Start () {
		spawnpoint = GameObject.Find ("Spawner").GetComponent<GameObject> ();

	}
	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerExit (Collider col){
		switch (col.gameObject.tag) {
		case "LevelCollider":
			transform.position = spawnpoint.transform.position;
			break;
		}
	}
}
