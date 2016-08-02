using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	// Use this for initialization
    public int playerHealth;
    public int playerArmor;
    public int playerShield;
    public double playerShieldMitigation;
    public GUIText statHealth;
    public GUIText statShield;
    public GameObject gameController;
    public bool isAlive;
	void Start () {
        statHealth.text = "Health " + playerHealth.ToString();
        statShield.text = playerShield.ToString() + " Shield";
        isAlive = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        statHealth.text = "Health " + playerHealth.ToString();
        statShield.text = playerShield.ToString() + " Shield";

        if (playerShield > 80)
        {
            statShield.color = Color.green;
        }
        else if (playerShield > 40)
        {
            statShield.color = Color.yellow;
        }
        else
        {
            statShield.color = Color.red;
        }

        if (playerShield < 0)
        {
            playerShield = 0;
        }

        if (playerHealth > 80)
        {
            statHealth.color = Color.green;
        }
        else if (playerHealth > 40)
        {
            statHealth.color = Color.yellow;
        }
        else if (playerHealth > 0)
        {
            statHealth.color = Color.red;
        }
        else
        {
            playerHealth = 0;
            statHealth.text = "Health " + playerHealth.ToString();
            gameController.GetComponent<Done_GameController>().GameOver("player");
            Destroy(this.gameObject);
        }
	}
}
