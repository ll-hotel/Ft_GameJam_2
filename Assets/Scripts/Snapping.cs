using UnityEngine;

[ExecuteAlways]
public class SnapToGridInEditor : MonoBehaviour
{
	[SerializeField] private Vector3 gridSize = new(1f, 1f, 1f);
	[SerializeField] private Vector3 cellOffset = new(0.5f, 0.5f, 1f);

	private void Update()
	{
		var pos = transform.position;
		transform.position = new Vector3(
			Mathf.RoundToInt(pos.x / gridSize.x) * gridSize.x + cellOffset.x,
			Mathf.RoundToInt(pos.y / gridSize.y) * gridSize.y + cellOffset.y,
			pos.z);
	}
}
