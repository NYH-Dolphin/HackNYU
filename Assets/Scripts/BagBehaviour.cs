using UnityEngine;

namespace DefaultNamespace
{
    public class BagBehaviour : MonoBehaviour
    {
        private static int _fullNum;
        private MyObject _myObject = MyObject.Empty;

        public bool full => _myObject != MyObject.Empty;

        public void RegisterObject(MyObject obj)
        {
            _myObject = obj;
            OnHaveItem();
            if (++_fullNum == 8)
            {
                OnMiniGameEnd();
            }

            Debug.Log(_myObject.ToString());
        }


        public void OnMiniGameEnd()
        {
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