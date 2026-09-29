using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    ScoreManager scoreManager;
    public GameObject obstaclePrefab;
    public float SpawnPositionX = 12f;
    float cooldown = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownspawn();
    }

    void spawnobstacle(){
        Instantiate(obstaclePrefab, new Vector3(SpawnPositionX, Random.Range(-1.5f, 1.5f), 0), Quaternion.identity);
    }

    void cooldownspawn(){
        if (cooldown <= 0){
            spawnobstacle();
            //cooldown = Random.Range(3f, 5f);
            cooldown = Mathf.Max(1.5f, 3f - (scoreManager.score / 100f));
        } else {
            cooldown -= Time.deltaTime;
        }
    }
}
