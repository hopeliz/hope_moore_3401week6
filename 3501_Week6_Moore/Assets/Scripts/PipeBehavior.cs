using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehavior : MonoBehaviour {

    public float moveSpeed = 5.0F;
    public float despawnXPosition = -10.0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        if (transform.position.x < despawnXPosition)
        {
            Destroy(gameObject);
        }
	}
}
