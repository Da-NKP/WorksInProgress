using UnityEngine;
using System.Collections;

[System.Serializable]
public class Done_Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

public class Done_PlayerController : MonoBehaviour
{
	public float speed;
	public float tilt;
	public Done_Boundary boundary;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
    public float fireOverload;
    public float moveOverload;
	 
	private float nextFire;
    private float defaultRate;
    private bool isOverload;
    private float fireOverloadValue = 0;
	
    void Start()
    {
        defaultRate = fireRate;
        fireOverloadValue = fireRate / fireOverload;
    }

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}

        if (Input.GetButton("Fire2"))
        {
            fireRate = fireOverloadValue; 
            isOverload = true;
        }
        else
        {
            fireRate = defaultRate;
            isOverload = false;
        }
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
        if (isOverload)
        {
            GetComponent<Rigidbody>().velocity = movement * speed * (1 / moveOverload);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = movement * speed;
        }
		
		GetComponent<Rigidbody>().position = new Vector3
		(
			Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		);
		
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
	}
}
