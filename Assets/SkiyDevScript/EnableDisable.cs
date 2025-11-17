using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    private void OnEnable() 
    {
        Debug.Log("Kod aktif edildi.");
    }
    private void OnDisable() 
    {
        Debug.Log("Kod deaktif edildi.");
    }
}
