using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<GameObject> targets;

    private float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score = 0;

    public bool isGameOver = false;

    public Button restartButton;

    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget() {
        while (!isGameOver) {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            //setScoreText(scoreText, ++score);
        }
    }

    public void addToScore(int amountToAdd) {
        score += amountToAdd;
        setScoreText(scoreText, score);
    }

    void setScoreText(TextMeshProUGUI scoreGUI, int newScore) {
        scoreGUI.text = "Score: " + newScore;
    }

    public void StartGame(string difficulty) {
        StartCoroutine(SpawnTarget());
        setScoreText(scoreText, 0);
        titleScreen.gameObject.SetActive(false);
        switch(difficulty) {
            case "Easy":
                spawnRate /= 3;
            break;
            case "Medium":
                spawnRate /= 2;
            break;
            case "Hard":
                spawnRate /= 1;
            break;
        }
    }

    public void GameOver() {
        gameOverText.gameObject.SetActive(true);
        isGameOver = true;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
