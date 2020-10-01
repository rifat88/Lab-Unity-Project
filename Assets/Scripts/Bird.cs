using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float speed; 
    Rigidbody2D rb;

    //references
    public Score scoreText;
    public GameObject replayBtn;
 
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();

    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //flap effect
            rb.velocity = Vector2.up * speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Column"))
        {
            print("Score Up");
            scoreText.ScoreUp();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") ||
           collision.gameObject.CompareTag("Pipe"))
        {
            //game over 
            Time.timeScale = 0;
            replayBtn.SetActive(true);
        }
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
