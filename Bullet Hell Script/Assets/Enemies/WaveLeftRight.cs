using UnityEngine;

public class WaveLeftRight : Enemy
{
    float SineWaveTime;

    protected override void movement()
    {
        //Calculate the sine wave
        SineWaveTime += Time.deltaTime * 7;


        // Move left, changing movement speed acording to the sine wave
        transform.position -= new Vector3(CurrentWaveSpeed() + (Mathf.Sin(SineWaveTime) * ScoreManager.Instance.ModifierSpeed), 0, 0) * Time.deltaTime;
    }
}
