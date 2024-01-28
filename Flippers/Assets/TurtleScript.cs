using System;
using UnityEngine;

public class TurtleScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float SwimVelocity = 10;
    public ScoreManager ScoreManager;

    public bool IsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        this.ScoreManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 5 && transform.position.y >= -5)
        {
            if (Input.GetKeyDown(KeyCode.Space) && IsAlive)
            {
                myRigidBody.velocity = Vector2.up * SwimVelocity;
            }
        }
        else
        {
            this.ScoreManager.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.IsAlive = false;
        this.ScoreManager.GameOver();
    }
}