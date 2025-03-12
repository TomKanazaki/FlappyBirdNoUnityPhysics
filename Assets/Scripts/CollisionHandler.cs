using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private FlyBahaviour bird;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject pipes;
    [SerializeField] private GameController gameController; 

    void Update()
    {
        if (gameController.IsGameOver) return; 

        if (bird.transform.position.y < ground.transform.position.y)
        {
            Debug.Log("GAME OVER! Collided with Ground");
            gameController.GameOver();
        }

        if (pipes != null)
        {
            //if (AAAB(bird.gameObject, pipes))
            //{
            //    Debug.Log("GAME OVER! Collided with Pipe");
            //    gameController.GameOver();
            //}

            if (bird.transform.position.x >= pipes.transform.position.x) {
                Debug.Log("GAME OVER! Collided with Pipe");
                gameController.GameOver();
            }
        }
            
    }

    private bool AAAB(GameObject pl, GameObject p)
    {
        if (pl == null || p == null) return false;

        Bounds boundsPl = pl.GetComponent<SpriteRenderer>().bounds;
        Bounds boundsP = p.GetComponent<SpriteRenderer>().bounds;

        return boundsPl.Intersects(boundsP);
    }
}
