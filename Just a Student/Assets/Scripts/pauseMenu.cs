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

		StartCoroutine ("Wait");

	}

	IEnumerator Wait(){

		float fadeTime = GameObject.Find ("GameController").GetComponent<FadeTransition>().BeginFade(1);
		yield return new WaitForSeconds(3);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel(0);

	}
}
