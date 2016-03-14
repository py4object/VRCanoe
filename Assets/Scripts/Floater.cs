using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Floater : MonoBehaviour {

	public float speed=0.5f;
//	public float minimum = 10.0F;
	//public float maximum = 20.0F;

	public Rigidbody rb;

	public float UpwardForce = 10.2f; 
	private bool isInWater = false;

	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("water")) {
			isInWater = false;
			rb.drag = 0.05f;
		}
		//Debug.logger.Log (other.tag);
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("obstacle"))
		{
			other.gameObject.SetActive (false);
			canoeController.Heath = -10;
			Debug.logger.Log (other.tag);
		}
		if (other.gameObject.CompareTag ("water")) {
			isInWater = true;
			rb.drag = 1f;
		}

	}

	void OnCollisionEnter(Collision collision)
	{
//		Debug.logger.Log (collision.gameObject.tag);
//		if (collision.gameObject.CompareTag ("obstacle")) {
//			collision.gameObject.SetActive (false);
//
//		}
	}

	private Canoe canoeController;
	void Start () {/**/
		
		canoeController = new Canoe ();
		rb = GetComponent<Rigidbody> ();

	}



	void Update () {
		//canoeController.Float (minimum, maximum, speed);
/*
		 * the fllowing code should be removed
		*/

		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis ("Vertical");
	
	
		rb.AddRelativeForce (new Vector3 (y, 0, 0)*speed,ForceMode.Acceleration);
		transform.Rotate (transform.up * x);


	}
	void FixedUpdate() {
		if(isInWater) {
			// apply upward force
			Vector3 force = transform.up * UpwardForce;
			this.rb.AddRelativeForce(force, ForceMode.Acceleration);
		//	Debug.Log("Upward force: " + force+" @"+Time.time);
		}
	}
}