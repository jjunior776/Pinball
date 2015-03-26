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
<<<<<<< HEAD
=======
	
	// Update is called once per frame
	void Update () {
		if (balls <= 0) {
		
		
		}
	}
>>>>>>> 1cee62a07cdf22ab48f401a8bc6970be574a3e6d
}
