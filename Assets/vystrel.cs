using UnityEngine;
using System.Collections;

public class vystrel : MonoBehaviour {
	public Transform mistoVystrelu;
	public LayerMask kulicka;
	float radius = 1f;
	bool pripravenKVystrelu=false;


	// Use this for initialization
	void FixedUpdate () {
		pripravenKVystrelu = Physics2D.OverlapCircle (mistoVystrelu.position, radius,  kulicka);

	}
	
	// Update is called once per frame
	void Update () {
		if ((pripravenKVystrelu == true)&&(Input.GetKeyUp(KeyCode.Space))) {
			Debug.Log("vystreleno");

		}
	}
}
