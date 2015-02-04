using UnityEngine;
using System.Collections;

public class palka : MonoBehaviour {

	public Transform pivot;
	Vector3 rotujNa = new Vector3(0,0,1);
	public float uhel = 90;
	bool otevreno=false;
	public KeyCode klavesa;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetKeyDown(klavesa))&&(otevreno==false)){
			transform.RotateAround (pivot.position, rotujNa, uhel);
			otevreno=true;
		}
		if ((Input.GetKeyUp (klavesa)) && (otevreno == true)) {
			transform.RotateAround (pivot.position, rotujNa, -uhel);
			otevreno=false;
		}

	}
}
