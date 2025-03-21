using System.Collections.Generic;
using UnityEngine;

public class PathStart : MonoBehaviour
{
	[SerializeField] private GameObject enemyType;
	[SerializeField] private GameObject enemyGoal;
	Queue<GameObject> toBeSpawnedEnemies;

	void Start()
	{
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
