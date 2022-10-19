using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class script_Text_sena_2 : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private string[] text_show;
    [SerializeField] private GameObject Switching_On_No;
    [SerializeField] private GameObject Switching_On_Yes;

    private int text_index;

    private void Start()
    {
        StartCoroutine(_Output(text_show[text_index], 0.02f));

        text_index++;
    }
    public void OnPointerDown()
    {
        if (text_index == 5)
        {
            StopAllCoroutines();

            text_index++;
            text.text = "";
            this.gameObject.SetActive(false);
        }
        if (text_index == 3)
        {
            StopAllCoroutines();

            Switching_On_No.SetActive(true);
            Switching_On_Yes.SetActive(true);
            text_index++;
            text.text = "";
        }
        else
        {
            text.text = "";
            StopAllCoroutines();
            StartCoroutine(_Output(text_show[text_index], 0.02f));
            text_index++;
        }
    }

    IEnumerator _Output(string str, float delay)
    {
        foreach (char sym in str)
        {

            text.text += sym;

            yield return new WaitForSeconds(delay);
        }
    }

}

