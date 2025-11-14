using UnityEngine;

public class Deneme1 : MonoBehaviour
{
    // illa [SerializeField] ihityacımız yok şuan artık sadece inspector da görünmüyordu bunun için kullandık.
   [SerializeField] private Rigidbody _rigidbody;

   private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
    // Awake, oyun objesi aktif olmadan önce çalışır.
    // Bu satır ile objedeki Rigidbody componentini alıyoruz ve _rigidbody değişkenine atıyoruz.
    // Böylece script içinde Rigidbody’ye erişip kullanabiliriz.
    // [SerializeField] sayesinde istersen Inspector'dan da atama yapabilirsin.anabilriz.
    }

    private void Start() {
        _rigidbody.useGravity = true;
        transform.position = new Vector3(60, 60, -4);
    }
}
