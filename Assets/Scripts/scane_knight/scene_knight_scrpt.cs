using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scene_knight_scrpt : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private string[] text_show;
    [SerializeField] private GameObject Switching_object_off;
    [SerializeField] private GameObject Switching_object_on;

    private void OnEnable()
    {
        StartCoroutine(_Output0(text_show[0], 0.02f));

    }

    public void switch_scene_3()
    {
        Switching_object_off.SetActive(false);
        Switching_object_on.SetActive(true);
    }
   

    IEnumerator _Output0(string str, float delay)
    {
        foreach (char sym in str)
        {

            text.text += sym;

            yield return new WaitForSeconds(delay);
        }
    }

}

