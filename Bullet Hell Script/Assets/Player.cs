using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float PlayerSpeed = 5;
    public Vector2 PlaySpace;
    public Sprite NormalShip;
    public Sprite BoostingShip;
    SpriteRenderer shipRenderer;
    public float ShipBoostValue = 200;
    public Slider BoostVisualiser;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get the sprite renderer to be used later
        shipRenderer = GetComponent<SpriteRenderer>();
        //Set the Boost Slider MaxValue & Value to the boost value.
        BoostVisualiser.maxValue = ShipBoostValue;
        BoostVisualiser.value = ShipBoostValue;
    }

    // Update is called once per frame
    void Update()
    {
        //When the player presses escape, close the game.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //Check if the player has boost, if there is boost, continue, otherwise set the sprite rederer to the regular ship.
        float CurrentShipSpeed = PlayerSpeed;
        if (ShipBoostValue > 0)
        {
            //Is pressing Left Shift, set the ship sprite to the boosting ship, remove Ship Boost, and multiple the ship speed by 1.5
            if (Input.GetKey(KeyCode.LeftShift))
            {
                shipRenderer.sprite = BoostingShip;
                CurrentShipSpeed = CurrentShipSpeed * 1.5f;
                ShipBoostValue -= Time.deltaTime;
                BoostVisualiser.value = ShipBoostValue;
            }
            //Is NOT pressing Left Shift, set the ship sprite to the regular ship.
            else
            {
                shipRenderer.sprite = NormalShip;
            }
        }
        else
        {
            shipRenderer.sprite = NormalShip;
        }

        //Move Player using WASD / Arrow keys
        float y = Input.GetAxisRaw("Vertical");
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x, y) * Time.deltaTime * CurrentShipSpeed;

        //Keep player within the playspace
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -PlaySpace.x, PlaySpace.x), Mathf.Clamp(transform.position.y, -PlaySpace.y, PlaySpace.y));
    }
}
