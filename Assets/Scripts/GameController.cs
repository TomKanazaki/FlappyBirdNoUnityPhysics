using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool IsGameOver { get; private set; } = false;

    public void GameOver()
    {
        IsGameOver = true;
        Time.timeScale = 0.0f;
        Debug.Log("Game Over! Press Space bar to Restart!");
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGameOver && Input.GetKeyDown(KeyCode.Space)) {
            RestartGame();
        }    
    }

    private void RestartGame()
    {
        Time.timeScale = 1.0f;
        Debug.ClearDeveloperConsole();
        SceneManager.LoadScene("GamePlay");
    }
}
