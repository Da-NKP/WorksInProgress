using UnityEngine;
using System.Collections;

public class POV_Movement : MonoBehaviour {
	public float zoom;
	private GameObject Marble;
	private Transform POV;
	public GameObject Map;
	// Use this for initialization
	void Start () {
	POV = GetComponent<Transform>();
	Marble = GameObject.FindGameObjectWithTag("Player");
	zoom = 2;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		POV.position = new Vector3(Marble.transform.position.x, Marble.transform.position.y + zoom, Marble.transform.position.z);
		//POV.rotation = Map.transform.rotation;
	}
}
