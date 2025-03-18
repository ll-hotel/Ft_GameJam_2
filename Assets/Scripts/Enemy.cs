using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Enemy : MonoBehaviour
{
	public float            hp = 10;
	public TextMeshProUGUI  txt;
	public GameObject goal;

	void	Start()
	{
		DisplayText();
	}

	void FixedUpdate()
	{
		Vector2 distance = (goal.transform.position - transform.position);
		Vector3 step = distance.normalized * 0.05f;
		if (distance.magnitude < step.magnitude)
			step = distance;
		transform.position += step;
	}

	void	TakeDamage(float dmg)
	{
		if (dmg > hp)
			hp = 0f;
		else
			hp -= dmg;
		DisplayText();
	}

	void	DisplayText()
	{
		txt.text = "HP:" + hp.ToString();
	}
}
