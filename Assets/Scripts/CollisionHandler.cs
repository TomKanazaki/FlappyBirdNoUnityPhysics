using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private FlyBahaviour bird;
    [SerializeField] private GameController gameController;

    void Update()
    {
        if (gameController.IsGameOver) return;

        GameObject ground = GameObject.FindGameObjectWithTag("Ground");
        if (ground != null && AABB(bird.gameObject, ground))
        {
            Debug.Log("GAME OVER! Collided with Ground");
            gameController.GameOver();
            return;
        }

        foreach (GameObject pipe in GameObject.FindGameObjectsWithTag("Pipe"))
        {
            if (pipe == null) continue;

            if (AABB(bird.gameObject, pipe))
            {
                Debug.Log("GAME OVER! Collided with Pipe");
                gameController.GameOver();
                return;
            }
        }
    }

    private bool AABB(GameObject a, GameObject b)
    {
        if (a == null || b == null) return false;

        Bounds boundsA = a.GetComponent<SpriteRenderer>().bounds;
        Bounds boundsB = b.GetComponent<SpriteRenderer>().bounds;

        return (boundsA.min.x < boundsB.max.x && boundsA.max.x > boundsB.min.x &&
                boundsA.min.y < boundsB.max.y && boundsA.max.y > boundsB.min.y);
    }
}
