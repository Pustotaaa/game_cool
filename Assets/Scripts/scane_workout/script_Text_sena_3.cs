using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class script_Text_sena_3 : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private string[] text_show;
    [SerializeField] private GameObject Switching_off_2;
    [SerializeField] private GameObject Switching_off;

    private int text_index;

    private void Start()
    {
        StartCoroutine(_Output(text_show[text_index], 0.02f));

        text_index++;
    }
    public void OnPointerDown()
    {
        Switching_off.SetActive(false);
        Switching_off_2.SetActive(false);
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

