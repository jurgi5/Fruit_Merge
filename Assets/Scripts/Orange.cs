using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public int scoreValue = 2;
    public GameObject coconutPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Orange"))
        {
            int collisionCount = PlayerPrefs.GetInt("OrangeCollisionCount", 0);
            collisionCount++;
            PlayerPrefs.SetInt("OrangeCollisionCount", collisionCount);

            PlayerPrefs.Save();

            Vector3 collisionPosition = collision.contacts[0].point;
            
            Destroy(collision.gameObject);
            Destroy(gameObject);

            if (collisionCount % 2 == 0)
            {
                Instantiate(coconutPrefab, collisionPosition, Quaternion.identity);
            }
        }
    }
}
