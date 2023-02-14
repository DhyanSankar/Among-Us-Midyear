using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class NextLeveler : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Scene scene = SceneManager.GetActiveScene();
                String name = scene.name;
                if(name == "Level 1")
                    SceneManager.LoadScene("Level 2");
                else if(name == "Level 2")
                    SceneManager.LoadScene("Level 3");
            }
        }
    }
}
