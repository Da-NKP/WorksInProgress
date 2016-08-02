using UnityEngine;
using System.Collections;

public class EndOfStage : MonoBehaviour {
	public GameController gameController;
	public LevelController levelController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			gameController.NextLevel();
			levelController.NextLevel();
		}
	}
}
