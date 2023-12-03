using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class RainSpawnBehaviour : MonoBehaviour
    {
        public List<Transform> Positions;
        public GameObject RaindropPrefab;

        public TextMeshProUGUI time;

        private void Start()
        {
            StartCoroutine(GenerateRain());
            StartCoroutine(CountDown());
        }

        IEnumerator GenerateRain()
        {
            for (int i = 50; i >= 0; i--)
            {
                int idx = Random.Range(0, Positions.Count);
                GameObject rain = Instantiate(RaindropPrefab);
                rain.transform.position = Positions[idx].position;
                yield return new WaitForSeconds(0.8f);
            }
        }

        IEnumerator CountDown()
        {
            for (int i = 20; i >= 0; i--)
            {
                time.text = "Time Left: " + i + "s";
                yield return new WaitForSeconds(1f);
                if (i <= 10)
                {
                    time.color = Color.red;
                }
            }

            OnMiniGameEnd();
        }

        public void OnMiniGameEnd()
        {
            SceneManager.LoadScene("ending");
        }
    }
}