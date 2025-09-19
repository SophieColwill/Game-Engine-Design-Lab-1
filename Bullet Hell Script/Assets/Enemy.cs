using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Enemy : MonoBehaviour
{
    protected abstract void movement();

    private void Update()
    {
        //Use the movement code for the enemy.
        movement();

        //If enemy is off screen, destory it so it doesn't use up more data.
        if (transform.position.x <= -ScoreManager.Instance.EnemySpawnAreaX)
        {
            Destroy(gameObject);
        }
    }

    //When the player overlaps with the enemy, the enemy dies and restart the match. Also access the score Manager "Match Ended" void to reset stuff up.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(0);
            ScoreManager.Instance.MatchEnded();
        }
    }

    //Calculate the current speed of the enemy, based off of the current wave.
    protected float CurrentWaveSpeed()
    {
        return ScoreManager.Instance.BaseSpeed + (ScoreManager.Instance.SpeedPerWave * (ScoreManager.Instance.Wave - 1));
    }
}
