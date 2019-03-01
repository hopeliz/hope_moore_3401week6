using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour {

    public Rigidbody2D birdRb;
    public GameObject gameOverCanvas;
    public float jumpSpeed = 5.0F;
    public bool gameOver = false;
    public Text scoreText;
    public Text finalScoreText;
    public int score = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                birdRb.velocity = new Vector2(birdRb.velocity.x, birdRb.velocity.y + jumpSpeed);
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameOver)
        {
            gameOverCanvas.SetActive(true);
            finalScoreText.text = finalScoreText.text + " " + score.ToString();
            gameOver = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.text = score.ToString();
    }
}
