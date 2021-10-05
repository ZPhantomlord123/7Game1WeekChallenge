using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject pipes;
    public TextMeshProUGUI score;
    public float timer = 0;
    public float currentScore = 0;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Time.timeScale == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    private void FixedUpdate()
    {
        timer++;
        if (timer >= 60)//60 frames
        {
            timer = 0;
            GameObject pipe = Instantiate(pipes, new Vector2(pipes.transform.position.x+10, pipes.transform.position.y + Random.Range(-2,2)), pipes.transform.rotation); 
            Destroy(pipe,6);
        }
    }

    public void PlayerScore()
    {
        currentScore++;
        score.text = currentScore.ToString();
    }
}
