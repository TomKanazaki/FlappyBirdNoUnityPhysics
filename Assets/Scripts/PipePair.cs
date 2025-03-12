using UnityEngine;

public class PipePair : MonoBehaviour
{
    private bool scored = false;

    private void Update()
    {
        if (scored || ScoreText.Instance == null) return;

        GameObject bird = GameObject.FindGameObjectWithTag("Player");

        if (bird != null && bird.transform.position.x > transform.position.x + 2 )
        {
            scored = true;
            ScoreText.Instance.IncreaseScore();
        }
    }
}
