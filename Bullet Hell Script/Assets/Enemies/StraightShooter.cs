using UnityEngine;

public class StraightShooter : Enemy
{
    // Move Left
    protected override void movement()
    {
        transform.position -= new Vector3(CurrentWaveSpeed(), 0, 0) * Time.deltaTime;
    }
}
