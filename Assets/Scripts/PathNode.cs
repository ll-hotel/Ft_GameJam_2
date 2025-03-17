using UnityEngine;

public class PathNode : MonoBehaviour
{
	[SerializeField] GameObject redirect;

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Enemy")
			collider.GetComponent<Enemy>().goal = redirect;
	}
}
