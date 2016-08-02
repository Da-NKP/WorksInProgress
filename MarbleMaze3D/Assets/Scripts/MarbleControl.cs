using UnityEngine;
using System.Collections;

public class MarbleControl : MonoBehaviour {
	public float magnitude;
	public GameController Controller;
	private Transform rigid;
	public float value;
	// Use this for initialization
	void Start () {
	rigid = GetComponent<Transform>();
	magnitude = 2.5f;
	}
	
	// Update is called once per frame
	void FixedUpdate () //Code Borrowed from Unity Tutorial
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (Mathf.Clamp(moveVertical/magnitude, -value, value), 0.0f, Mathf.Clamp(-moveHorizontal/magnitude,-value, value));
		
		rigid.transform.Rotate(movement);
		
		Controller.SetAngles((int)rigid.rotation.eulerAngles.z, (int)rigid.rotation.eulerAngles.x);
	}
}
