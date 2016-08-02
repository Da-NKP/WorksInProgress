using UnityEngine;
using System.Collections;

public class BossWeapons : MonoBehaviour {

	// Use this for initialization
    public GameObject normalShot;
    public GameObject gameController;
    public GameObject bigShot;
    public float normShotSpeed;
    public int bigOdds;
    //public int bigShotSpeed;
    //public float bigDelay;
    public float normDelay;
    public GameObject[] shotSpawns;
    public GameObject bigShotSpawn;
    private bool isFiring;

    void Start()
    {
        isFiring = false;
    }

    void FixedUpdate()
    {
        bool isGameOver = gameController.GetComponent<Done_GameController>().gameOver;

        if(this.gameObject.GetComponent<BossMover>().isLoading != true && !isFiring)
        {
            InvokeRepeating("Fire", normDelay, normShotSpeed);
            isFiring = true;
        }

        if (isGameOver)
        {
            CancelInvoke("Fire");
        }
    }

    void Fire()
    {
        foreach (GameObject shotSpawn in shotSpawns)
        {
            Instantiate(normalShot, shotSpawn.transform.position, shotSpawn.transform.rotation);
            GetComponent<AudioSource>().Play();
        }

        int number = Random.Range(0, bigOdds + 1);

        if (number == 0)
        {
            FireBig();
        }

        if (gameController.GetComponent<Done_GameController>().gameOver)
        {
            CancelInvoke("Fire");
        }
    }

    void FireBig()
    {
        Instantiate(bigShot, bigShotSpawn.transform.position, bigShotSpawn.transform.rotation);
        //GetComponent<AudioSource>().Play();
    }
}
