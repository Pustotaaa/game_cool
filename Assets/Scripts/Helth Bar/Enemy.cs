using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
	[SerializeField] private Player player;
    [SerializeField] private GameObject button_attack_player;
	public int maxHealth;
	public int currentHealth;

	public HealthBar healthBar;

    void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	public void Attack_Enemy()
	{
		player.TakeDamage(3);
		Invoke("swiching_motion", 2f);
	}
	private void swiching_motion()
	{
		//button_attack.GetComponent<Button>().enabled = true;
		button_attack_player.GetComponent<Button>().enabled = true;
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}

	
}
