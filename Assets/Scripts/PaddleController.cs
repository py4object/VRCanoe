using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float y = Input.GetAxis ("Vertical")*Time.deltaTime;
		float x =  Input.GetAxis("Horizontal")*Time.deltaTime;
	//	Debug.logger.Log (x + " " + y);
		Rigidbody r = GetComponent<Rigidbody> ();
		//r.AddTorque (transform.up*y);
		r.AddTorque (transform.forward*x);
		Debug.logger.Log (x);
	}

}
