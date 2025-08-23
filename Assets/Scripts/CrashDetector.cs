using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{

    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float sceneLoadDelay = 2f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", sceneLoadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    
}
