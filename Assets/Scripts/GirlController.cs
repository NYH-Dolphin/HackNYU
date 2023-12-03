using UnityEngine;

namespace DefaultNamespace
{
    public class GirlController : MonoBehaviour
    {
        [SerializeField] private float fSpeed = 4f;

        private void Update()
        {
            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                transform.Translate(new Vector3(1, 0, 0) * fSpeed * Time.deltaTime);
            }
            else if (Input.GetMouseButton(1)|| Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                transform.Translate(new Vector3(1, 0, 0) * fSpeed * Time.deltaTime);
            }
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log(other.name);
        }
        
    }
}