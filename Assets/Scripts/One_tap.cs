using UnityEngine;
public class One_tap : MonoBehaviour
{
    [SerializeField] private GameObject Switching_On;
    [SerializeField] private GameObject Switching_On_2;

    public void Off()
    {
        Switching_On.SetActive(true);
        Switching_On_2.SetActive(true);
        this.gameObject.SetActive(false);

    }



}
