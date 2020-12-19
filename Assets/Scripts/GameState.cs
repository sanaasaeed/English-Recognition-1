using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class GameState : MonoBehaviour
{
    private Animator basketAnimation;
    [SerializeField] private GameObject targetAlphabet;
    [SerializeField] private TextMeshProUGUI scoreText;
    public static Sprite target;
    [SerializeField] private List<Sprite> alphabets;
    private int count = 0;
    public static int levelScore;

    public bool isTargetSet = false;
    void Start() {
        basketAnimation = FindObjectOfType<Animator>();
        SetLevelScore();
    }

    public void SetTarget() {
        target = alphabets[Random.Range(0, 25)];
        targetAlphabet.GetComponent<SpriteRenderer>().sprite = target;
        isTargetSet = true;
    }
    

    public void AnimateBasket() {
        basketAnimation.enabled = true;
    }

    public void StopAnimation() {
        basketAnimation.enabled = false;
    }

    public void IncreaseScore() {
        count += 10;
        scoreText.text = count.ToString();
    }

    public void DecreaseScore() {
        count -= 10;
        scoreText.text = count.ToString();
    }

    public void SetLevelScore() {
        if (SceneManager.GetActiveScene().buildIndex == 1) {
            levelScore = 100;
        } else if (SceneManager.GetActiveScene().buildIndex == 2) {
            levelScore = 300;
        } else if (SceneManager.GetActiveScene().buildIndex == 3) {
            levelScore = 500;
        }
    }
}
