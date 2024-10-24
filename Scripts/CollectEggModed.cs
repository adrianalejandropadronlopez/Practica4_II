using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectEggModed : MonoBehaviour
{
    private int pointsGroup1 = 0;
    private int pointsGroup2 = 0;
    public CubeCollisionControllerModed collisionHandler;
    public Cube2CollisionControllerModed collisionHandler2;
    public Text scoreText1;
    public Text scoreText2;
    public Text winnerText;

    // Start is called before the first frame update
    void Start() {
        collisionHandler.OnCollisionDetectedWithEggPlayer1 += AddPointsPlayer1;
        collisionHandler2.OnCollisionDetectedWithEggPlayer2 += AddPointsPlayer2;
        scoreText1.text = "Player 1 points: " + pointsGroup1;
        scoreText2.text = "Player 2 points: " + pointsGroup2;
        winnerText.enabled = false;
    }

    void AddPointsPlayer1() {
        pointsGroup1 += 5;
        scoreText1.text = "Player 1 points: " + pointsGroup1;
        scoreText2.text = "Player 2 points: " + pointsGroup2;
        if (pointsGroup1 >= 20) {
            scoreText1.enabled = false;
            scoreText2.enabled = false;
            winnerText.text = "Player 1 wins!";
            winnerText.enabled = true;
            GameObject.FindGameObjectWithTag("Player1").SetActive(false);
            GameObject.FindGameObjectWithTag("Player2").SetActive(false);
        }
    }

    void AddPointsPlayer2() {
        pointsGroup2 += 5;
        scoreText1.text = "Player 1 points: " + pointsGroup1;
        scoreText2.text = "Player 2 points: " + pointsGroup2;
        if (pointsGroup2 >= 20) {
            scoreText1.enabled = false;
            scoreText2.enabled = false;
            winnerText.text = "Player 2 wins!";
            winnerText.enabled = true;
            GameObject.FindGameObjectWithTag("Player1").SetActive(false);
            GameObject.FindGameObjectWithTag("Player2").SetActive(false);
        }
    }
}
