using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float BackSpeed;
    public Animator BackScroller;
    public float MidSpeed;
    public Animator MidScroller;
    public float FrontSpeed;
    public Animator FrontScroller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Set scroll Speeds
        BackScroller.speed = BackSpeed;
        MidScroller.speed = MidSpeed;
        FrontScroller.speed = FrontSpeed;
    }
}
