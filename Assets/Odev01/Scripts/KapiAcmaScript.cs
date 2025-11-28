using UnityEngine;

public class KapiAcmaScript : MonoBehaviour
{
    public float AcilisAcisi=90f;
    public float AcilisSuresi=2f;
    private bool AcilmaDurumu=false;//yeni kapalı durumdaysa bu kapalı durumu da açısından anlayacğız
    private Quaternion BaslangicDegeri;
    private Quaternion Bitisdegeri;

    void Start()
    {
        BaslangicDegeri =transform.rotation;
        Bitisdegeri= Quaternion.Euler(0,AcilisAcisi,0);

        AcilmaDurumu=true;
    }
    void Update()
    {
        if(AcilmaDurumu)
        {
            transform.rotation=Quaternion.Lerp(transform.rotation,Bitisdegeri,Time.deltaTime*AcilisSuresi);
        }
    }
}
