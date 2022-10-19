using UnityEngine;

public class Move : MonoBehaviour
{
    public new Transform transform;
    private void Update ()
    {
        for (int i = 10; i > 0; i++)
        {
            transform.position = new Vector3(1, i, 1);
        }
        
    }
}
