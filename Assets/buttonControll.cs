using UnityEngine;
using System.Collections;

public class buttonControll : MonoBehaviour {
	public UnityEngine.UI.InputField jmenoText;
	string jmeno;
	public scoreBoard sc;

	public void menu(){
		Application.LoadLevel ("menu");
	}
	
	public void zapisSkore(){
		jmeno = jmenoText.text;
		sc = new scoreBoard ();
		sc.loadScoreSimple ();
		sc.addScore (jmeno, gameControll.score);
		sc.saveScore ();

		Application.LoadLevel ("scoreboard");
	}

	public void levejOdpal(){
		Input.GetKey ("D");

	}

	public void pravejOdpal(){
	}
}
