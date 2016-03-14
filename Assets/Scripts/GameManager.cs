using UnityEngine;
using System.Collections;

/*This class is a singlton and it acts as a gamemanger 
 * As the project go ,this class should offer easy(lazy) refrence to every needed Object
 * 
*/
public class GameManager  {
	public GameObject Canoe;
	// Use this for initialization
	static private GameManager instance=null;
	public static GameManager Instance{get{ 
		
			if (instance == null) {
				instance= new GameManager ();


			}
			return instance;
		}
		private set{ }}


	private GameManager(){
		Canoe = GameObject.Find ("Canoe");
	}
}
