using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class KnapsackManager : MonoBehaviour
    {
        public List<BagBehaviour> bags;
        public static KnapsackManager Instance;
        public TextMeshProUGUI time;
        
        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            StartCoroutine(CountDown());
        }

        IEnumerator CountDown()
        {
            for (int i = 120; i >= 0; i--)
            {
                time.text = "Time Left: " + i + "s";
                yield return new WaitForSeconds(1f);
                if (i <= 20)
                {
                    time.color = Color.red;
                }
            }
            OnMiniGameEnd();
        }

        public void OnMiniGameEnd()
        {
            foreach (var bag in bags)
            {
                if (!bag.full || bag.myObject == MyObject.Empty || bag.myObject == MyObject.Others)
                {
                    Debug.Log("Noooo");
                    return;
                }
            }

            Debug.Log("yees!");
        }
    }
}