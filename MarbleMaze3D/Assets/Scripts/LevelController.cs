using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
	public GameObject Marble;
	public GameObject end;
	public GameObject StartZone;
	public GameObject Stage;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		/*
		if (end.CompareTag("Player"))
		{
			Controller.NextLevel();
		}
		*/
	}
	
	public void NextLevel()
	{
		Stage.transform.rotation = new Quaternion(0,0,0,0);
		Marble.transform.position = StartZone.transform.position;
	}
	
	
}
