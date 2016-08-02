using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	public int level;
	public int MaxLevel;
	private int vertAngle;
	private int horizAngle;
	public GameObject Marble;
	public GameObject MainCamera;
	public GameObject Stage;
	public GameObject EndText;
	public GameObject horiz;
	public GameObject vert;
	//private Component[] LevelOneComps;
	//private Component[] LevelTwoComps;
	
	// Use this for initialization
	void Start () {
	level = 1;
	vertAngle = 0;
	horizAngle = 0;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		horiz.GetComponent<Text>().text = "Horizontal Axis: " + horizAngle.ToString();
		vert.GetComponent<Text>().text = "Vertical Axis: " + vertAngle.ToString();
	}
	
	public void EndOfGame()
	{
		//End the game!!!
		
		//Set Main Camera
		//13x6.5x12.3
		//30x-138x0
		Camera mainCam = MainCamera.GetComponentInChildren<Camera>();
		MainCamera.GetComponent<POV_Movement>().enabled = false;
		mainCam.transform.position.Set(13f,6.5f,12.3f);
		mainCam.transform.rotation.eulerAngles.Set(30f,-138f,0f);
		
		//disable controls
		Stage.GetComponent<MarbleControl>().enabled = false;
		
		
		//display message
		EndText.GetComponent<MeshRenderer>().enabled = true;
		
		
	}
	
	public void NextLevel()
	{
		level++;
		switch(level)
		{
			case 1:
				
				break;
			case 2:
				
				break;
			default:
				
				break;
		}
	}
	
	public void SetAngles(int vertical, int horizontal)
	{
		vertAngle = vertical;
		horizAngle = horizontal;
	}
}
