using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class dialogueString : MonoBehaviour {

	public string stringOne;
	public Text stringText;
	public float fadeTime;
	public bool displayInfo;

	// Use this for initialization
	void Start () {

		stringText = GameObject.Find ("Dialogue String Text").GetComponent<Text>();
		stringText.color = Color.clear;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){

		displayInfo = true;
	}

	void FadeText(){

		if (displayInfo){

			stringText.text = stringOne;
			stringText.color = Color.Lerp(stringText.color, Color.white, fadeTime * Time.deltaTime);

	}else{

		stringText.color = Color.Lerp(stringText.color, Color.clear, fadeTime * Time.deltaTime);
		}
	}
}
