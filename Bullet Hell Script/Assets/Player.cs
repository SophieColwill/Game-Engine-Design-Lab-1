using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxisRaw("Vertical");
        float x = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(x, y) * Time.deltaTime * PlayerSpeed;
    }
}
