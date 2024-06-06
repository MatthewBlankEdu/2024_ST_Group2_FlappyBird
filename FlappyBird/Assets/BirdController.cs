using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public Vector2 JumpForce;

    public static bool GameOver;
    public static bool HasStarted;

    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        HasStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
            return;

        if(Input.GetButtonDown("Jump"))
        {
            if(HasStarted == false)
            {
                HasStarted = true;
                rb2D.gravityScale = 1;
            }

            rb2D.AddForce(JumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver = true;
    }
}
