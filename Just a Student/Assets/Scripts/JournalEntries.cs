using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JournalEntries : MonoBehaviour {

	public Canvas notebookInventory;
	public Button april2011;
	public Text aprilEntry;

	// Use this for initialization
	void Start () {
		aprilEntry.enabled = false;

		notebookInventory = notebookInventory.GetComponent<Canvas>();

		april2011 = april2011.GetComponent<Button>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void April2011(){

		aprilEntry.enabled = true;
	}
}
