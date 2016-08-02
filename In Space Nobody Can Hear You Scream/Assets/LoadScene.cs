using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {
    private AudioSource test;
	// Use this for initialization
	void Start () {
        test = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	if (test.enabled)
        {
            Application.LoadLevel("BulletHell");
        }
	}
}
