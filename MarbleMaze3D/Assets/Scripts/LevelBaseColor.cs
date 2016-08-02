using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class LevelBaseColor : MonoBehaviour {
	
	private Renderer mesh;
	
	// Use this for initialization
	void Start () {
	mesh = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	mesh.material.color = Color.black;
	}
}
