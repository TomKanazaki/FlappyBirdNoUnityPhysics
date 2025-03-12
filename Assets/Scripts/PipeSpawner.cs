using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    [SerializeField] private float spawnRate = 1.5f;
    [SerializeField] private float heightRange = 0.22f;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, spawnRate);
    }

    void SpawnPipe()
    {
        Vector3 spawnPos = new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);
    }


}
