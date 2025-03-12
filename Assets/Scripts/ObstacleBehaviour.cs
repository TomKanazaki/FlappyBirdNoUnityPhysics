using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -3 ) //off screen
        {
            Destroy(gameObject); 
        }
    }
}
