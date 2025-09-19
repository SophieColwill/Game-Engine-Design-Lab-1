using UnityEngine;

public class WaveLeftRight : Enemy
{
    float SineWaveTime;

    protected override void movement()
    {
        SineWaveTime += Time.deltaTime * 7;

        transform.position -= new Vector3(CurrentWaveSpeed() + (Mathf.Sin(SineWaveTime) * ScoreManager.Instance.ModifierSpeed), 0, 0) * Time.deltaTime;
    }
}
