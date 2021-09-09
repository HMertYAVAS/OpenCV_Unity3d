using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemy1;
    public float enemySpawnSec = 20.0f;
    public float enemySpawnStartSec = 10.0f;
    float enemySpeed;
    float enemyLifeTime =10.0f;
    float enemyRestartLifeTime= 20.0f;
    Vector3 enemySpawnPos;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnEnemy", enemySpawnStartSec, enemySpawnSec);


    }

    // Update is called once per frame
    void Update()
    {
        //Enemy lifeTime
        if (enemyLifeTime > 0)
        {
            enemyLifeTime -= Time.deltaTime;
        }else{
            enemyLifeTime = enemyRestartLifeTime;
            Destroy(enemy1.gameObject);
        }

    }

    void SpawnEnemy(){


        Vector3 enemySpawnPos = transform.position;
        enemySpawnPos.x = (Random.Range (-10, 10));
        enemySpawnPos.y = (Random.Range (-10, 10));
        enemySpawnPos.z = -0.50f;

        Instantiate(enemy1, enemySpawnPos, Quaternion.identity);

        

        //this part just for spawn enemy area. its not important

        // if(enemySpawnPos.x < 0 && enemySpawnPos.y < 0){
        //     Instantiate(enemy1, enemySpawnPos, Quaternion.identity);
        // }
        
        // if(enemySpawnPos.x < 0 && enemySpawnPos.y < 0){
        //     Instantiate(enemy1, enemySpawnPos, Quaternion.identity);
        // }
    }



}
