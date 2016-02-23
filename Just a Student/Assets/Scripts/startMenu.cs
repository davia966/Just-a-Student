using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startMenu : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;

	public AudioSource introMusic;
	public float fadeSpeed = 10f;
	public bool startFade = false;
	float time = 0f;

	// Use this for initialization
	void Start () {

		quitMenu = quitMenu.GetComponent<Canvas>();
		startText = startText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();

		quitMenu.enabled = false;

	}

	// Update is called once per frame
	void Update () {

		if (startFade){

			introMusic.volume = Mathf.Lerp(1f, 0f, time);
			time += Time.deltaTime / fadeSpeed;
		}
	}

	public void ExitPress(){
		
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}
	
	public void NoPress(){
		
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
		
	}
	
	public void StartLevel(){

		startFade = true;
		StartCoroutine ("Wait");
	}
	
	public void ExitGame(){
		
		Application.Quit();
	}

	IEnumerator Wait(){

		float fadeTime = GameObject.Find ("GameController").GetComponent<FadeTransition>().BeginFade(1);
		yield return new WaitForSeconds(5);
		//float fadeTime = GameObject.Find ("GameController").GetComponent<FadeTransition>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);

		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
