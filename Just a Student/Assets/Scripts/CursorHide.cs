using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class CursorHide : MonoBehaviour {

	bool CursorLockedVar;
	public Canvas crossHair;
	public Canvas pauseMenu;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		CursorLockedVar = true;
		GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;
		crossHair = crossHair.GetComponent<Canvas>();

		crossHair.enabled = true;
		pauseMenu.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && CursorLockedVar == false){ // || Input.GetKeyDown (KeyCode.Tab) && CursorLockedVar == false){
		//if (Input.GetKeyDown (KeyCode.Tab) && CursorLockedVar == false){
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			CursorLockedVar = true;
			GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;
			crossHair.enabled = true;
			pauseMenu.enabled = false;

		} else if (Input.GetKeyDown (KeyCode.Escape) && CursorLockedVar == true){ // || Input.GetKeyDown (KeyCode.Tab) && CursorLockedVar == true) {
		//} else if (Input.GetKeyDown (KeyCode.Tab) && CursorLockedVar == true) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			CursorLockedVar = false;
			GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
			crossHair.enabled = false;
			pauseMenu.enabled = true;
		}
	}
}