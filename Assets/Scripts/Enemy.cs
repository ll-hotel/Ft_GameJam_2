using UnityEngine;
using TMPro;

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
		Vector2 direction = (goal.transform.position - transform.position);
		Vector3 step = direction.normalized * 0.05f;
		if (direction.magnitude < goal.GetComponent<CircleCollider2D>().radius)
			step = direction;
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
