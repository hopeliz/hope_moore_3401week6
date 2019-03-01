using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuckController : MonoBehaviour
{

    public Rigidbody2D duckRb;
    public AudioSource quackSound;
    public AudioSource pointSound;
    public AudioSource failSound;
    public GameObject gameOverCanvas;
    public float diveSpeed = 5.0F;
    public bool gameOver = false;
    public Text scoreText;
    public Text finalScoreText;
    public int score = 0;
    
    public float duckYPosition;
    
    void Update()
    {
        if (!gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                duckRb.velocity = new Vector2(duckRb.velocity.x, duckRb.velocity.y - diveSpeed);
                quackSound.Play();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameOver)
        {
            failSound.Play();
            gameOverCanvas.SetActive(true);
            finalScoreText.text = finalScoreText.text + " " + score.ToString();
            gameOver = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            pointSound.Play();
        }
        
    }
}
