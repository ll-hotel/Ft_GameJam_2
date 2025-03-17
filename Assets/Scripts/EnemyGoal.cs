using UnityEngine;
using TMPro;

public class EnemyGoal : MonoBehaviour
{
	public float hp = 10;
	public TextMeshProUGUI hp_text;

    void Start()
    {
    }

	public void TakeDamage(float amount)
	{
		hp -= amount % hp;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Enemy")
			Destroy(collider.gameObject);
	}
}
