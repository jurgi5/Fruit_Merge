using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public int scoreValue = 0;
    public GameObject coconutPrefab;
    private int counter = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Orange"))
        {
            counter++;
            Vector3 collisionPosition = collision.contacts[0].point;    
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (counter % 2 == 0)
            {
                Instantiate(coconutPrefab, collisionPosition, Quaternion.identity);
            }
        }
    }

    private void Update()
    {
        print(counter);
    }

}
