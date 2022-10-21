using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class choice_yes : MonoBehaviour
{
    [SerializeField] private GameObject Switching_off;
    [SerializeField] private GameObject Switching_On;

    public void EnableText()
    {
        Button button = Switching_On.GetComponent<Button>();
        button.enabled = true;

        Switching_off.SetActive(false);
        this.gameObject.SetActive(false);

    }
}
