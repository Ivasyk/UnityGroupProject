using System;
using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	
	void OnTriggerEnter(Collider col){
		switch (col.gameObject.tag) {
		case "platform":
			Application.LoadLevel("group scene 1");
			break;
		case "Maze2":
			Application.LoadLevel("MazeGroupUnity");
			break;
		case "maze1":
			Application.LoadLevel("level1");
			break;
		case "portal":
			Application.LoadLevel("GameHub");
			break;
		}
	}
}