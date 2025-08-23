using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;



public class RidingEffect : MonoBehaviour
{

    [SerializeField] ParticleSystem ridingEffect;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ridingEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ridingEffect.Stop();
        }
    
        
    }
}
