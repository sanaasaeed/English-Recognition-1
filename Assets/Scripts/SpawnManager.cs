using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour {
    [SerializeField] List<GameObject> spawningObjects;
    [SerializeField] float delay = 2;
    [SerializeField] public float interval = 2.0f;
    [SerializeField] public float xRange = 5.5f;
    [SerializeField] public float yPos = 8f;

    private void Start() {
        InvokeRepeating(nameof(SpawnRandomAlphabets), delay, interval);
    }
    void SpawnRandomAlphabets() {
        int alphaIndex = Random.Range(0, spawningObjects.Count);
        Vector2 spawnPosition = new Vector2((Random.Range(-xRange, xRange)), yPos);
        Instantiate(spawningObjects[alphaIndex], spawnPosition, spawningObjects[alphaIndex].transform.rotation);
    }
}
