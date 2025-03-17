using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class point : MonoBehaviour
{
	private Vector3 mousePos;

	void OnPoint(InputValue context)
	{
		mousePos = Camera.main.ScreenToWorldPoint(context.Get<Vector2>());
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
    }
    void Update()
	{
		mousePos.z = 0;
		transform.position = mousePos;
	}

}
