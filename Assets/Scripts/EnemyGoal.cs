using UnityEngine;
using TMPro;

public class EnemyGoal : MonoBehaviour
{
	public float hp = 10;
	public TextMeshProUGUI hp_text;

    // Start is called before the first frame update
    void Start()
    {
    }

	public void TakeDamage(float amount)
	{
		hp -= amount % hp;
	}
}
