using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBehavior : MonoBehaviour
{

    public float moveSpeed = 5;
    public float despawnXPosition = -22;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        if (transform.position.x < despawnXPosition)
        {
            Destroy(gameObject);
        }
    }
}
