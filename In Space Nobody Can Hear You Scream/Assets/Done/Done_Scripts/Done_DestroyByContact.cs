using UnityEngine;
using System.Collections;

public class Done_DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private Done_GameController gameController;
    private GameObject player;
    private GameObject boss;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <Done_GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary" || other.tag == "Enemy")
		{
			return;
		}

		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
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

            Component playerScript = other.GetComponent<PlayerHealth>();

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

        if (other.tag == "Boss")
        {
            boss = other.gameObject;
            int pHealth = other.GetComponent<BossHealth>().bossHealth;
            int pArmor = other.GetComponent<BossHealth>().bossArmor;

            int hDamage = gameController.GetComponent<WeaponDamages>().playerDamage;

            if (boss.GetComponent<BossMover>().isLoading == false)
            {
                other.GetComponent<BossHealth>().bossHealth -= (hDamage - pArmor);
            }

            if (other.GetComponent<BossHealth>().bossHealth <= 0)
            {
                //Destroy(other.gameObject);
                Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
                //gameController.GameOver("null");
            }
            Destroy(gameObject);
        }
		
		gameController.AddScore(scoreValue);
		
        if (other.tag != "Player" && other.tag != "Boss")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
	}
}