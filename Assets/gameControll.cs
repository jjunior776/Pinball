using UnityEngine;
using System.Collections;

public class gameControll : MonoBehaviour {
	public static int score = 0;
	public static int balls = 3;
	int sizeX= 100;
	int sizeY= 25;
	public int positionY=5;
	void OnGUI () {
		GUI.Box (new Rect (0, 0, sizeX, sizeY), "Body: "+score);
		GUI.Box (new Rect (0,(sizeY+3),sizeX,sizeY), "Míčky: "+ balls);
	}

	void Start () {
		score = 0;
		balls = 3;
	}
}
