using UnityEngine;
using System.Collections;

public class NotebookInvetory : MonoBehaviour {

	public GameObject Inventory;
	private bool isShowing;

	// Use this for initialization
	void Start () {

		isShowing = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Tab)) {
			isShowing = !isShowing;
			Inventory.SetActive (isShowing);

		}
		if (isShowing == true) {
			Time.timeScale = 0.0f;
		} else {
			Time.timeScale = 1.0f;
		}
	}
}
