using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour
{
    public int scoreValue = 7;
    public GameObject orangePrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Watermelon"))
        {
            int collisionCount = PlayerPrefs.GetInt("WatermelonCollisionCount", 0);
            collisionCount++;
            PlayerPrefs.SetInt("WatermelonCollisionCount", collisionCount);

            int totalScore = PlayerPrefs.GetInt("TotalScore", 0);
            totalScore += scoreValue;
            PlayerPrefs.SetInt("TotalScore", totalScore);

            PlayerPrefs.Save();

            Vector3 collisionPosition = collision.contacts[0].point;

            Destroy(collision.gameObject);
            Destroy(gameObject);

            if (collisionCount % 2 == 0)
            {
                // Instantiate(orangePrefab, collisionPosition, Quaternion.identity);
            }
        }
    }
}
