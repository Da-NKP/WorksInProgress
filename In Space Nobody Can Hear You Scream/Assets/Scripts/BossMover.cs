using UnityEngine;
using System.Collections;

public class BossMover : MonoBehaviour {

	// Use this for initialization
    public GameObject gameController;
    public float leftBound;
    public float rightBound;
    public float initMoveSpeed;
    public float reallyInitSpeed;
    public float reallyInitPos;
    public float normMoveSpeed;
    public float initStartPos;
    public float initEndPos;
    public float posOffScreen;
    public bool isLoading;
    private int flipValue;
    private bool isInMiddle;
    private bool isOffScreen;

    //private Transform actualTransform;
	void Start () {
        isLoading = true;
        flipValue = 1;
        isOffScreen = false;
        isInMiddle = false;
        //actualTransform = this.gameObject.GetComponentInChildren<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        bool isGameOver = gameController.GetComponent<Done_GameController>().gameOver;
        
        if (isLoading && !isGameOver)
        {
            Vector3 movement = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, initEndPos);
            GetComponentInChildren<Rigidbody>().velocity = movement * initMoveSpeed * -1;
        }
        else if (!isGameOver)
        {
            Vector3 movement = new Vector3(initEndPos, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            GetComponentInChildren<Rigidbody>().velocity = movement * initMoveSpeed * flipValue * normMoveSpeed;
        }

        if (this.gameObject.transform.position.z <= initEndPos && !isGameOver)
        {
            isLoading = false;
            this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (this.gameObject.transform.position.x <= leftBound)
        {
            flipValue = 1;
        }

        if (this.gameObject.transform.position.x >= rightBound)
        {
            flipValue = -1;
        }

        if (isGameOver && isInMiddle && !isOffScreen)
        {
            Vector3 movement = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, initEndPos);
            GetComponentInChildren<Rigidbody>().velocity = movement * initMoveSpeed * -1;

            if (this.gameObject.transform.position.z == posOffScreen)
            {
                isOffScreen = true;
            }
        }

        if (isGameOver && !isInMiddle)
        {
            Vector3 movement = new Vector3(initEndPos, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            GetComponentInChildren<Rigidbody>().velocity = movement * initMoveSpeed * flipValue * normMoveSpeed;

            #region oldCode 
            /*
            if (this.gameObject.transform.position.x == 0)
            {
                isInMiddle = true;
                this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
            }

            if (this.gameObject.transform.position.x < 0.1)
            {
                flipValue = 1;
            }

            if (this.gameObject.transform.position.x > -0.1)
            {
                flipValue = -1;
            }
            */
#endregion

            if (this.gameObject.transform.position.x > -0.1)
            {
                //flipValue = 1;
            }
            else if (this.gameObject.transform.position.x < 0.1)
            {
                //flipValue = -1;
            }
        }

        if ((this.gameObject.transform.position.x <= 0.2f && this.gameObject.transform.position.x >= -0.2f) && isGameOver)
        {
            isInMiddle = true;
            this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
        }
	}
}
