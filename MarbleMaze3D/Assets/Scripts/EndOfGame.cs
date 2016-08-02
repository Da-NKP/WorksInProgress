using UnityEngine;
using System.Collections;

public class EndOfGame : MonoBehaviour {
	public GameController gameController;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			gameController.EndOfGame();
			
		}
	}
	
	
}
