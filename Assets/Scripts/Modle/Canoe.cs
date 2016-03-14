using UnityEngine;
using System.Collections;
/*This a modle supposed to represent the Canoe
 * most of the logic of controlling the canoe will go here
 *
*/
public class Canoe{
	public int Heath {
		get;
		set;
	}

	public int Life{set;get;}
	private bool up;//determine the direction of the floating motion of the canoe (going up or down )
	private float startTime;//timestamp 
	private GameObject canoeView;//represent the view object of the canoe 

	public Canoe(){ 
		startTime = Time.time;
		canoeView = GameManager.Instance.Canoe;
		Heath = 100;
	}

	/*This method will simulate a the floating motion on water (note that this implemention is to be Changed
	 * 
	*/
	public void Float(float minumLeve,float maxmiumLeve,float speed){
		float duration = (Time.time - startTime)*speed;
		float place = duration / (maxmiumLeve-minumLeve);
		if (up) {
			if (place >= 1) {
				up = false;
				startTime = Time.time;
				return;
			}
			canoeView.transform.position = new Vector3 (canoeView.transform.position.x, Mathf.Lerp (minumLeve, maxmiumLeve, place), canoeView.transform.position.z);
		} else {
			if (place >= 1) {
				up = true;
				startTime = Time.time;
				return;
			}
			canoeView.transform.position = new Vector3 (canoeView.transform.position.x, Mathf.Lerp ( maxmiumLeve,minumLeve, place), canoeView.transform.position.z);
		}


	}

}
