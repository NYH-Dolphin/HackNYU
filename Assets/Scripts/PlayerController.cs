using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerController : MonoBehaviour
    {
        private GameObject _objSelected;
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SelectObject();
            }

            if (Input.GetMouseButtonUp(0))
            {
                if (_objSelected != null)
                {
                    _objSelected.GetComponent<MyObjectBehaviour>().CheckRegisterBag();
                }

                _objSelected = null;
            }

            if (Input.GetMouseButton(0))
            {
                if (_objSelected != null)
                {
                    Vector2 pos = _camera.ScreenToWorldPoint(Input.mousePosition);
                    _objSelected.transform.position = pos;
                }
            }
        }

        private void SelectObject()
        {
            RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.CompareTag("MyObject"))
                {
                    _objSelected = hit.collider.gameObject;
                }
            }
        }
    }
}