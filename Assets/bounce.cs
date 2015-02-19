using UnityEngine;
using System.Collections;

public class bounce : MonoBehaviour {
	bool bounced = false;
	public SliderJoint2D guma;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D micek){
		if (micek.tag == "micek") { 
			if (bounced == false) {

				bounced = true;
			}
		}

	}

	void OnTriggerExit2D(Collider2D micek){
		if (micek.tag == "micek") {
			bounced = false;
		}
	}
}