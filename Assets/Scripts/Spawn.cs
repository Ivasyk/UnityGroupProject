using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	private GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerExit (Collider other){
		transform.position = new Vector3(-3.16f, 0.54f, 5.15f);
	}
}
