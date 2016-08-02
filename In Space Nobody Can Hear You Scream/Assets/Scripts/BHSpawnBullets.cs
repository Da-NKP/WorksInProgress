using UnityEngine;
using System.Collections;

public class BHSpawnBullets : MonoBehaviour {

	// Use this for initialization
    public GameObject shot;
    private float nextFire;
    public float fireRate;
    public Transform shotSpawn;
    public int minShots;
    public int maxShots;
    public float delay;

	void Start () {
        InvokeRepeating("Fire", delay, fireRate);
	}

    private void Fire()
    {
        int number = Random.Range(minShots, maxShots + 1);
        for (int i = 0; i < number; i++)
        {
            float rotation = 0;
            switch (i)
            {
                case 5:
                    rotation = 90;
                    break;
                case 4:
                    rotation = -90;
                    break;
                case 3:
                    rotation = -45;
                    break;
                case 2:
                    rotation = 45;
                    break;
                default:
                    rotation = 0;
                    break;
            }

            nextFire = Time.time + fireRate;
            Quaternion shotRotation = shotSpawn.rotation;
            shotRotation.x += rotation;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play();
        }
    }
}
