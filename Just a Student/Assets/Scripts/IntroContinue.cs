using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IntroContinue : MonoBehaviour {

	public Button continueText;

	public AudioSource schoolAmbient;
	public float fadeSpeed = 5f;
	public bool startFade = false;
	float time = 0f;

	// Use this for initialization
	void Start () {

		continueText = continueText.GetComponent<Button>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (startFade){
			
			schoolAmbient.volume = Mathf.Lerp(0.3f, 0f, time);
			time += Time.deltaTime / fadeSpeed;
		}
	
	}

	public void StartLevel(){

		startFade = true;
		StartCoroutine ("Wait");

	}
	IEnumerator Wait(){

		float fadeTime = GameObject.Find ("GameController").GetComponent<FadeTransition>().BeginFade(1);
		yield return new WaitForSeconds(3);
		yield return new WaitForSeconds(fadeTime);
		
		Application.LoadLevel(Application.loadedLevel + 1);

	}
}
