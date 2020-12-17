using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private GameObject _template;

    private void Start()
    {
        SpawnBall(_template, _spawnPoint);
    }

    private void SpawnBall(GameObject template, Transform[] spawnPoint)
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            Instantiate(template, spawnPoint[i].position, Quaternion.identity);
        }
    }
}
