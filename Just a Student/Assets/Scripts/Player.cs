using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;
	GameObject itemAdd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		crouch();
	
	}

	private void crouch(){
		if (Input.GetKeyDown(KeyCode.C)){
			GetComponent<CharacterController>().height = 0.7f;
		} else if (Input.GetKeyUp(KeyCode.C)){
			GetComponent<CharacterController>().height = 1.8f;
		}
	}
}
