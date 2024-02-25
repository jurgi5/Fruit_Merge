using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coconut : MonoBehaviour
{
    public int scoreValue = 5;
    public GameObject watermelonPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coconut"))
        {
            int collisionCount = PlayerPrefs.GetInt("CoconutCollisionCount", 0);
            collisionCount++;
            PlayerPrefs.SetInt("CoconutCollisionCount", collisionCount);

            PlayerPrefs.Save();

            Vector3 collisionPosition = collision.contacts[0].point;

            Destroy(collision.gameObject);
            Destroy(gameObject);

            if (collisionCount % 2 == 0)
            {
                Instantiate(watermelonPrefab, collisionPosition, Quaternion.identity);
            }
        }
    }
}
