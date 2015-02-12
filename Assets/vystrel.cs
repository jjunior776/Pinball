using UnityEngine;
using System.Collections;

public class vystrel : MonoBehaviour {
	public Transform mistoVystrelu;
	public LayerMask kulicka;
	float radius = 0.5f;
	bool pripravenKVystrelu=false;
	SliderJoint2D hj;
	JointMotor2D j = new JointMotor2D();

	// Use this for initialization
	void FixedUpdate () {
		pripravenKVystrelu = Physics2D.OverlapCircle (mistoVystrelu.position, radius,  kulicka);
		hj = gameObject.GetComponent<SliderJoint2D>();

	}
	
	// Update is called once per frame
	void Update () {
		j.motorSpeed = -10000;
		j.maxMotorTorque = 500;
		if ((pripravenKVystrelu == true)&&(Input.GetKey(KeyCode.Space))) {
			j.motorSpeed = 100;
		}
		hj.motor = j;
	}
}
