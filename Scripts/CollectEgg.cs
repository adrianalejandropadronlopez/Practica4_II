using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectEgg : MonoBehaviour
{
    private int pointsGroup1 = 0;
    private int pointsGroup2 = 0;
    private int rewards = 0;
    public CubeCollisionController collisionHandler;
    public Text scoreText1;
    public Text scoreText2;
    public Text rewardText;

    // Start is called before the first frame update
    void Start()
    {
        collisionHandler.OnCollisionDetectedWithEgg += AddPoints;
        scoreText1.text = "Spiders group1 points: " + pointsGroup1;
        scoreText2.text = "Spiders group2 points: " + pointsGroup2;
        rewardText.text = "Rewards: " + rewards;
    }

    void AddPoints() {
        pointsGroup1 += 5;
        pointsGroup2 += 10;
        scoreText1.text = "Spiders group1 points: " + pointsGroup1;
        scoreText2.text = "Spiders group2 points: " + pointsGroup2;
        // incrementar rewards cada vez que se superen los 100 puntos
        if (pointsGroup1 + pointsGroup2 >= 100) {
            rewards++;
            rewardText.text = "Rewards: " + rewards;
            pointsGroup1 = 0;
            pointsGroup2 = 0;
            scoreText1.text = "Spiders group1 points: " + pointsGroup1;
            scoreText2.text = "Spiders group2 points: " + pointsGroup2;
        }
        // Debug.Log("Group 1 spiders: " + pointsGroup1 + " points");
        // Debug.Log("Group 2 spiders: " + pointsGroup2 + " points");
    }
}
