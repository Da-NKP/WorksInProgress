using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class MarbleColor : MonoBehaviour {
	private Renderer color;
	// Use this for initialization
	void Start () {
	color = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	color.material.color = Color.green;
	}
}
