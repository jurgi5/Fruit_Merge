using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeDropper : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float minX = -3f;
    public float maxX = 2.1f;
    public GameObject orangePrefab;
    public float dropInterval = 1f;
    private float lastDropTime;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float movement = horizontalInput * moveSpeed * Time.deltaTime;
        Vector3 newPosition = transform.position + new Vector3(movement, 0f, 0f);
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        transform.position = newPosition;

        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastDropTime >= dropInterval)
        {
            DropOrange();
            lastDropTime = Time.time;
        }
    }

    void DropOrange()
    {
        Instantiate(orangePrefab, transform.position, Quaternion.identity);
    }
}
