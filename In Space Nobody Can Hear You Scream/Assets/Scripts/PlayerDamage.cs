using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {

	// Use this for initialization
    private Done_GameController gameController;
    public GameObject explosion;
    public GameObject playerExplosion;
    private GameObject player;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Done_GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
	
	// Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (other.tag == "Player")
        {
            player = other.gameObject;
            int pHealth = other.GetComponent<PlayerHealth>().playerHealth;
            int pShield = other.GetComponent<PlayerHealth>().playerShield;
            int pArmor = other.GetComponent<PlayerHealth>().playerArmor;
            double pMit = other.GetComponent<PlayerHealth>().playerShieldMitigation;
            float mPercent = (float)(100 - pMit) / 100;

            int hDamage = gameController.GetComponent<WeaponDamages>().healthDamage;
            int sDamage = gameController.GetComponent<WeaponDamages>().shieldDamage;

            if (this.gameObject.name == "BH_Bolt-Enemy(Clone)")
            {
                hDamage = gameController.GetComponent<WeaponDamages>().bossDamage;
                sDamage = gameController.GetComponent<WeaponDamages>().bossDamage;
            }

            if (this.gameObject.name == "Big_Bolt-Enemy(Clone)")
            {
                hDamage = gameController.GetComponent<WeaponDamages>().bossBigDamage;
                sDamage = gameController.GetComponent<WeaponDamages>().bossBigDamage;
            }

            if (pShield > 0)
            {
                other.GetComponent<PlayerHealth>().playerShield -= Mathf.RoundToInt(sDamage * mPercent);
            }
            else
            {
                other.GetComponent<PlayerHealth>().playerHealth -= (hDamage - pArmor);
            }

            if (other.GetComponent<PlayerHealth>().playerHealth <= 0)
            {
                //Destroy(other.gameObject);
                Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
                //gameController.GameOver("player");
            }

            Destroy(gameObject);
        }
    }
}
