using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Alphabets : MonoBehaviour {
    private GameState gameState;
    private float lowerLimit = 6;
    private Sprite target;
    [SerializeField] private List<Sprite> alphabets;
    
    private void Start() {
        gameState = FindObjectOfType<GameState>();
        if (gameObject.CompareTag("target")) {
            target = alphabets[Random.Range(0,25)];
            gameState.SetTargetAlphabet(target);
        }

        alphabets.Remove(target);
        GetComponent<SpriteRenderer>().sprite = alphabets[Random.Range(0, 24)];
    }

    void Update()
    {
        if (transform.position.y < -lowerLimit) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (gameObject.CompareTag("target")) {
            gameState.IncreaseScore();
            Destroy(gameObject);
        }
        else if(gameObject.CompareTag("enemy")) {
            gameState.AnimateBasket();
            // What to do when kid collect wrong alphabet
        }
        
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (!gameObject.CompareTag("target")) {
            gameState.StopAnimation();
        }
    }
}
