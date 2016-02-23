using UnityEngine;
using System.Collections;

public class NotebookVisibility : MonoBehaviour {

	public GameObject bookButton;
	public bool haveJournal;

	private bool isShowing = false;
	
	// Use this for initialization
	void Start () {

		haveJournal = false;

	}

	// Update is called once per frame

	void Interact () {
		isShowing = !isShowing;
		bookButton.SetActive(isShowing);
			
		bookButton.SetActive(true);
			
		Destroy(this.gameObject);
	}

	void Update(){

		haveJournal = true;

	}
}
