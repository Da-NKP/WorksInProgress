using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour {

	// Use this for initialization
    public int bossHealth;
    public int bossArmor;
    public GUIText statBossHealth;
    private int percent80, percent40, percent0;
    public GameObject gameController;
    public bool isAlive;

	void Start () {
        statBossHealth.text = "";
        percent80 = (int)(bossHealth * .8);
        percent40 = (int)(bossHealth * .4);
        percent0 = 0;
        isAlive = true;
        
        if (this.gameObject.GetComponent<BossMover>().isLoading != true)
        {
            statBossHealth.text = "HP: " + bossHealth.ToString();
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (this.gameObject.GetComponent<BossMover>().isLoading != true)
        {
            statBossHealth.text = "HP: " + bossHealth.ToString();
        }

        if (bossHealth > percent80)
        {
            statBossHealth.color = Color.green;
        }
        else if (bossHealth > percent40)
        {
            statBossHealth.color = Color.yellow;
        }
        else if (bossHealth > percent0)
        {
            statBossHealth.color = Color.red;
        }
        else
        {
            bossHealth = 0;
            statBossHealth.text = "HP: " + bossHealth.ToString();
            Destroy(this.gameObject);
            gameController.GetComponent<Done_GameController>().GameOver("boss");
        }
	}
}
