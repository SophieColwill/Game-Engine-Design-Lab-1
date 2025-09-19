using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed = 5;
    public Vector2 PlaySpace;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move Player using WASD / Arrow keys
        float y = Input.GetAxisRaw("Vertical");
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x, y) * Time.deltaTime * PlayerSpeed;

        //Keep player within the playspace
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -PlaySpace.x, PlaySpace.x), Mathf.Clamp(transform.position.y, -PlaySpace.y, PlaySpace.y));
    }
}
