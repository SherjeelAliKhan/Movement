using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


	Dictionary<KeyCode,Vector3> movementDictionary;
	float speed = 10;
	void Start () {
		movementDictionary = new Dictionary<KeyCode, Vector3>(){
			{KeyCode.W ,Vector3.forward},
			{KeyCode.S ,Vector3.back},
			{KeyCode.A ,Vector3.left},
			{KeyCode.D ,Vector3.right},
		};
	}
	
	void Update () {
		foreach (KeyCode key in movementDictionary.Keys) {
			if (Input.GetKey (key)) {
				transform.Translate (movementDictionary [key] * speed * Time.deltaTime, Space.Self);
			}
		}		
	}
}
