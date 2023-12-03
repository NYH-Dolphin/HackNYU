using System;
using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class RainDropBehaviour : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(CountDown());
        }

        IEnumerator CountDown()
        {
            yield return new WaitForSeconds(10f);
            Destroy(gameObject);
        }
    }
}