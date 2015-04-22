using UnityEngine;
using System.Collections;

public class palka : MonoBehaviour {

	bool otevreno=false;
	public KeyCode klavesa;
    public int mirroring = 1;
	public bool levaStrana;

    HingeJoint2D hj;
	JointMotor2D j = new JointMotor2D();
	// Use this for initialization
	void Start () {
	    hj = gameObject.GetComponent<HingeJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
		hj.motor = j;
		if ((Input.GetKey (klavesa))) {
			Odpal ();
		} else {
			j.motorSpeed = 2000 * mirroring;
			j.maxMotorTorque = 10000;
			//hj.motor = j;
			otevreno = false;
		}  

	for(int i = 0; i < Input.touchCount; i++){
		if (Input.GetTouch (i).phase == TouchPhase.Began) {
			if (levaStrana) {
				if (Input.GetTouch (i).position.x < Screen.width / 2) {
					Odpal ();
				}
			} else {
				if (Input.GetTouch (i).position.x > Screen.width / 2) {
					Odpal ();
				}
			}
		
		} else {
			j.motorSpeed = 2000 * mirroring;
			j.maxMotorTorque = 10000;
			//hj.motor = j;
			otevreno = false;
		}  
	}


	}

	public void Odpal(){
		
		j.motorSpeed = -2000*mirroring;
		j.maxMotorTorque = 10000;
		//hj.motor = j;
		otevreno=true;
	}
}
