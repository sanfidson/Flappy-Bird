using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float force;
    public int points;
    public int run = 1;


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            rigidBody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
    void RestartGame()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        run = 0;
        Debug.Log("You LOOOSE!!");
        Destroy(gameObject);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        points++;
        Debug.Log(points);
    }
}
