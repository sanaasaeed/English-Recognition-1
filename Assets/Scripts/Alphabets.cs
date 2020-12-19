using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Alphabets : MonoBehaviour {
    private GameState gameState;
    private float lowerLimit = 6;
    [SerializeField] private List<Sprite> alphabets;

    private void Start() {
         gameState = FindObjectOfType<GameState>();
         if (gameObject.CompareTag("target")) {
             // If target is not set already
             if (!gameState.isTargetSet) {
                 gameState.SetTarget();
             }
         }
         else {
            alphabets.Remove(GameState.target); 
            GetComponent<SpriteRenderer>().sprite = alphabets[Random.Range(0, 24)];
         }
    }

    void Update()
    {
        if (transform.position.y < -lowerLimit) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (gameObject.CompareTag("target")) {
            GetComponent<AudioSource>().Play();
            gameState.IncreaseScore();
            
         //   Destroy(gameObject);
        }
        else if(gameObject.CompareTag("enemy")) {
            GetComponent<AudioSource>().Play();
            gameState.DecreaseScore();
            gameState.AnimateBasket();
            // What to do when kid collect wrong alphabet
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (!gameObject.CompareTag("target")) {
            gameState.StopAnimation();
        }
    }
}
