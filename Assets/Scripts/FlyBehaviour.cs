using UnityEngine;

public class FlyBahaviour : MonoBehaviour
{
    [SerializeField] private float gravity = -5f;
    //[SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float jumpStrength = 5f;
    private Vector2 velocity;

    private void Update()
    {
        if ((Time.timeScale == 0)) return;

        velocity.y += gravity * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = jumpStrength;
        }

        transform.position += new Vector3(0, velocity.y * Time.deltaTime, 0);
        
    }
}
