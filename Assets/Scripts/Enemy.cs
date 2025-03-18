using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
	const float speed = 2f;
	TextMeshProUGUI hp_txt;
	float hp = 10f;
	GameObject goal;

	void Start()
	{
		hp_txt = GetComponentInChildren<TextMeshProUGUI>();
		UpdateText();
	}

	public void changeGoal(GameObject goal)
	{
		this.goal = goal;
		StartMoving();
	}

	public void StartMoving()
	{
		var distance = (goal.transform.position - transform.position);
		var body = GetComponent<Rigidbody2D>();
		body.totalForce = Vector2.zero;
		body.velocity = distance.normalized * speed;
	}

	public void TakeDamage(float dmg)
	{
		if (dmg > hp)
			hp = 0f;
		else
			hp -= dmg;
		UpdateText();
	}

	public virtual float attackDamage() { return 1f; }

	void UpdateText()
	{
		hp_txt.text = "HP:" + hp.ToString();
	}
}
