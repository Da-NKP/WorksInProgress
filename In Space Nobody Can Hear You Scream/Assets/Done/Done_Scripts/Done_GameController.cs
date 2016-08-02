using UnityEngine;
using System.Collections;

public class Done_GameController : MonoBehaviour
{
	public GameObject hazard;
    public GameObject boss;
    //public GameObject player;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
    public float timeToFlash;
    public int warningIterations;
    public int maxWaves;
    public int bossWait;
	
	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;
    public GUIText bossApproaching;
	
	public bool gameOver;
	private bool restart;
	private int score;
    private int waveCount;
    private string guiTextDefaultValue;
	
	void Start ()
	{
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
        guiTextDefaultValue = bossApproaching.text;
        bossApproaching.text = "";

        boss.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
	}
	
	void Update ()
	{
		if (restart)
		{
			if ((Input.anyKeyDown) && gameOver)
			{
				Application.LoadLevel ("MainMenu");
			}
		}
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
        waveCount = 0;
		while (waveCount < maxWaves)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
			
			if (gameOver)
			{
				restartText.text = "Press Any Key to Restart";
				restart = true;
				break;
			}
            int isOne = Random.Range(0, 2);

            if (isOne == 1)
            {
                hazardCount += 5;
            }
            waveCount++;
		}

        waveCount = maxWaves - 1;

        ReleaseTheBoss();

        for (int i = 0; i < warningIterations; i++)
        {
            bossApproaching.text = guiTextDefaultValue;
            yield return new WaitForSeconds(timeToFlash);
            bossApproaching.text = "";
            
            if (i != warningIterations -1)
            {
                yield return new WaitForSeconds(timeToFlash);
            }
        }
	}
	
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
        scoreText.text = "Score: " + score.ToString() + "\n" + "Wave: " + (waveCount + 1).ToString();
	}
	
	public void GameOver (string sender)
	{
		gameOverText.text = "Game Over!";

        if (sender != "player")
        {
            gameOverText.color = Color.green;
        }
        else
        {
            gameOverText.color = Color.red;
        }

		gameOver = true;
        restartText.text = "Press 'R' for Restart";
        restart = true;
	}

    private void ReleaseTheBoss()
    {
        boss.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}