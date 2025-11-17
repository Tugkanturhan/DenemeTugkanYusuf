using UnityEngine;
// bu sistemi ui envanter kapatma açam işleminde kullanabilriz.
public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private  GameObject _gameObject;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E basıldı ve kod aktif edildi.");
            _gameObject.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Esc'ye basıldı ve kod deaktif edildi.");
            _gameObject.SetActive(false);
        }
    }
}
