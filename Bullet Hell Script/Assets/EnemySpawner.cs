using NUnit.Framework;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float timeTillNextSpawn;
    public float SpawnAreaY;

    public EnemyWaveCounter[] SpawnableEnemies;

    private void Update()
    {
        //Add time, variable depending on the wave
        timeTillNextSpawn += Time.deltaTime * (ScoreManager.Instance.EnemySpawnerSpeedStart + ((ScoreManager.Instance.Wave - 1) * ScoreManager.Instance.EnemySpawnerSpeedPerWave));

        //if the time = 1, spawn a new enemy
        if (timeTillNextSpawn >= 1)
        {
            //take the 1 away, just in case a long frame drop
            timeTillNextSpawn -= 1;

            //check if the second item in the Spawnabe Enemies list can be spawned. If not auto spawn the base enemy, otherwise spawn a random enemy.
            if (ScoreManager.Instance.Wave < SpawnableEnemies[1].requiredWave)
            {
                SpawnEnemy(SpawnableEnemies[0].spawnableEnemy);
            }
            else
            {
                //Check what enemies are currently spawnable in this wave. Store that value
                int maxNumber = SpawnableEnemies.Length;
                for (int i = 0; i < SpawnableEnemies.Length; i++)
                {
                    if (ScoreManager.Instance.Wave < SpawnableEnemies[i].requiredWave)
                    {
                        maxNumber = i;
                    }
                }

                //Spawn a random enemy using the stored value from before
                int RandomEnemy = Random.Range(0, maxNumber);
                SpawnEnemy(SpawnableEnemies[RandomEnemy].spawnableEnemy);
            }
        }
    }

    //Reusable spawn enemy script to make it cleaner and more easily editable
    void SpawnEnemy(Enemy spawnEnemy)
    {
        Instantiate(spawnEnemy.gameObject, new Vector3(ScoreManager.Instance.EnemySpawnAreaX, Random.Range(-SpawnAreaY, SpawnAreaY)), spawnEnemy.transform.rotation);
    }
}

//Variable to add enemies & tell the script what wave they can spawn on.
[System.Serializable]
public class EnemyWaveCounter
{
    public Enemy spawnableEnemy;
    public int requiredWave;
}