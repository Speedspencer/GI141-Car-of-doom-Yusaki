using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class reload : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player")
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
