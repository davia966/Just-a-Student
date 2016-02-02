using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pauseMenu : MonoBehaviour {

	public Canvas pausedMenu;
	public Button mainButton;
	public Button settingsButton;


	// Use this for initialization
	void Start () {

		pausedMenu = pausedMenu.GetComponent<Canvas>();
		mainButton = mainButton.GetComponent<Button>();
		settingsButton = settingsButton.GetComponent<Button>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void MainMenuPress(){
		Application.LoadLevel(0);
	}
}
