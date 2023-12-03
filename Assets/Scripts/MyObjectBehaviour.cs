using System;
using UnityEngine;

namespace DefaultNamespace
{
    public enum MyObject
    {
        Empty,

        // Requirements
        Laptop,
        Charger,
        Notebook,
        Pen,
        WaterBottle,
        Snack,
        Attire,
        Headphone,
        Hygiene,
            
        // Other Stuffs many many
        Others,
    }

    public class MyObjectBehaviour : MonoBehaviour
    {
        public MyObject obj;
        [HideInInspector] public BagBehaviour bag;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Bag"))
            {
                if (!other.GetComponent<BagBehaviour>().full)
                {
                    if (bag != other.gameObject.GetComponent<BagBehaviour>())
                    {
                        if (bag != null)
                        {
                            bag.OnNotSelected();
                        }
                    }

                    bag = other.gameObject.GetComponent<BagBehaviour>();
                    bag.OnSelected();
                }
            }
        }


        private void Update()
        {
            if (transform.position.y > -2)
            {
                if (bag != null)
                {
                    bag.OnNotSelected();
                    bag = null;
                }
            }
        }


        public void CheckRegisterBag()
        {
            if (bag != null && !bag.full)
            {
                bag.RegisterObject(obj, GetComponent<SpriteRenderer>());
                Destroy(gameObject);
            }
        }
    }
}