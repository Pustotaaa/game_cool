using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;
	[SerializeField] private Text text;

	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;

		fill.color = gradient.Evaluate(1f);

		text.text = health.ToString() + "/" + slider.maxValue.ToString();
	}

    public void SetHealth(int health)
	{

		text.text = health.ToString() + "/" + slider.maxValue.ToString();
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}

}
