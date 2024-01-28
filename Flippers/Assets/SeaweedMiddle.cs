using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaweedMiddle : MonoBehaviour
{
    public ScoreManager ScoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        this.ScoreManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3) // Turtle Layer
        {
            this.ScoreManager.AddScore();      
        }
    }
}
