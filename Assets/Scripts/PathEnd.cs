using UnityEngine;
using TMPro;

public class PathEnd : MonoBehaviour
{
	public float hp = 10;
	public TextMeshProUGUI hp_text;

	void Start()
	{
		hp_text = GetComponentInChildren<TextMeshProUGUI>();
		UpdateText();
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Enemy") {
			TakeDamage(collider.GetComponent<Enemy>().attackDamage());
			Destroy(collider.gameObject);
		}
	}

	public void TakeDamage(float dmg)
	{
		if (dmg > hp)
			hp = 0f;
		else
			hp -= dmg;
		UpdateText();
	}

	void UpdateText()
	{
		hp_text.text = "HP:" + hp.ToString();
	}
}
