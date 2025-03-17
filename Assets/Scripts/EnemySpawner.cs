using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] private GameObject enemyType;
	[SerializeField] private GameObject enemyGoal;
	Queue<GameObject> spawnedEnemies;
	Queue<GameObject> toBeSpawnedEnemies;

	void Start()
	{
		spawnedEnemies = new Queue<GameObject>();

		toBeSpawnedEnemies = new Queue<GameObject>();
		toBeSpawnedEnemies.Enqueue(enemyType);
	}

	void FixedUpdate()
	{
		if (toBeSpawnedEnemies.Count > 0) {
			Transform transform = this.GetComponent<Transform>();

			var enemy = Instantiate(
					toBeSpawnedEnemies.Dequeue(),
					transform.position,
					transform.rotation
			);
			enemy.GetComponent<Enemy>().goal = enemyGoal;
		}
	}
}
