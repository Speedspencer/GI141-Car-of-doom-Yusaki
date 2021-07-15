using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class reload : MonoBehaviour
{

    public float timer = 0;
    public bool IsHit = false;
    public bool IsWin = false;
    public GameObject ExplosionPar;
    public GameObject SmokePar;
    public PlayerMoveWithForce1 playerMoveWithForce;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        if (IsHit == true)
        {
            timer += Time.deltaTime;
            ExplosionPar.SetActive(true);
            SmokePar.SetActive(false);
            playerMoveWithForce.Broken = true;

        }
        if (IsWin == true)
        {
            timer += Time.deltaTime;
            SmokePar.SetActive(false);
            playerMoveWithForce.Broken = true;

        }

        if (timer >= 3)
        {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    void OnCollisionEnter(Collision collision) {
        

        if (collision.gameObject.tag == "obstacle")
        {
        hit();
        }
    }

    public void hit () {
     
    IsHit = true;

    }

    public void win () {
        IsWin = true;
    }           
}

