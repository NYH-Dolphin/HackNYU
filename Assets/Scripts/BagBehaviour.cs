using UnityEngine;

namespace DefaultNamespace
{
    public class BagBehaviour : MonoBehaviour
    {
        private static int _fullNum;
        private SpriteRenderer _sr;
        [HideInInspector] public MyObject myObject = MyObject.Empty;

        public bool full => myObject != MyObject.Empty;


        private void Start()
        {
            _sr = transform.GetChild(0).GetComponent<SpriteRenderer>();
        }

        public void RegisterObject(MyObject obj, SpriteRenderer sr)
        {
            myObject = obj;
            _sr.sprite = sr.sprite;
            OnHaveItem();
            if (++_fullNum == 8)
            {
                _fullNum = 0;
                KnapsackManager.Instance.OnMiniGameEnd();
            }
        }


        public void OnSelected()
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }

        public void OnNotSelected()
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }

        private void OnHaveItem()
        {
            GetComponent<SpriteRenderer>().color = Color.gray;
        }
    }
}