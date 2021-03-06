using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower;
            GetComponent<AudioSource>().Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
    }
}
