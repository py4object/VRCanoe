using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	public float horizontalSpeed =1;
	public float verticalSpeed=1;
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(new Vector3(-verticalSpeed*Input.GetAxis("Mouse Y"),horizontalSpeed*Input.GetAxis("Mouse X"),0));
		
	}
}
