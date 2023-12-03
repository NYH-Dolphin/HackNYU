using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class ButtonBehaviour : MonoBehaviour
    {

        public void LoadGame()
        {
            SceneManager.LoadScene("start");
        }
    }
}