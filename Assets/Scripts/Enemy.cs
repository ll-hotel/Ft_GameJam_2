using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
	public float            hp = 10;
	public TextMeshProUGUI  txt;

	void	Start()
	{
		DisplayText();
	}
	void	Update()
	{
		
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
