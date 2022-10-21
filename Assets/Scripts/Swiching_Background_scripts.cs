using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class Swiching_Background_scripts : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private GameObject Object;

    public void OnEnable()
    {

        StartCoroutine(Swiching_Back());
        Debug.Log("lol");

    }

     IEnumerator Swiching_Back()
    {
       
        if (image.color.a == 1)
        {
            for (float i = 1; i >= 1;)
            {
                i -= 0.04f;
                image.color = new Color(0, 0, 0, i);
                if (i <= 0.02)
                {
                    Object.SetActive(false);
                }
                Debug.Log(i);
                yield return new WaitForSeconds(0.0005f);
            }
        }
        else
        {
            for (float i = 0; i <= 1;)
            {
                i += 0.04f;
                image.color = new Color(0, 0, 0, i);
                if (i >= 0.99f)
                {
                    Object.SetActive(false);
                }
                Debug.Log(i);
                yield return new WaitForSeconds(0.0005f);
            }
        }
        yield return 0;
    }
}
