using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    [SerializeField] private GameObject button_attack;
    private Status_player status_player = new Status_player();

    public int maxHealth;
    public int currentHealth;
    public static Func<bool, bool> onAttack;
    public HealthBar healthBar;

    void Start()
    {
        maxHealth = status_player.Player_helth;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void Attack_()
    {

        enemy.TakeDamage(status_player.Player_power_attack);
        button_attack.GetComponent<Button>().enabled = false;
        Invoke("swiching_motion", 2f);
        //button_attack.GetComponent<Button>().enabled = onAttack?.Invoke(true);
        //Invoke("Attack_Enemy", 3f);

    }

    private void swiching_motion()
    {
        //button_attack.GetComponent<Button>().enabled = true;
        enemy.Attack_Enemy();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
