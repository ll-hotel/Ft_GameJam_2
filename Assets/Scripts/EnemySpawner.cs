using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] private GameObject o;
	[SerializeField] private GameObject goal;
	Queue<GameObject> spawnedEnemies;
	Queue<GameObject> toBeSpawnedEnemies;

	void Start()
	{
		toBeSpawnedEnemies = new Queue<GameObject>();
		toBeSpawnedEnemies.Enqueue(o);

		spawnedEnemies = new Queue<GameObject>();
	}

	void FixedUpdate()
	{
		if (toBeSpawnedEnemies.Count > 0) {
			Transform transform = this.GetComponent<Transform>();

			Instantiate(
					toBeSpawnedEnemies.Dequeue(),
					transform.position,
					transform.rotation
			);
		}
	}
}
