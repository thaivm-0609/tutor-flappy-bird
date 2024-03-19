using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    Rigidbody2D rg;

    public GameObject gameOverObj;

    public float speed;
    // Start is called before the first frame update
    private void Start() 
    {
        Time.timeScale = 1;
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector2.up * speed);
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        gameOverObj.SetActive(true);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    public void playAgain()
    {
        SceneManager.LoadScene(0);
    }
}
