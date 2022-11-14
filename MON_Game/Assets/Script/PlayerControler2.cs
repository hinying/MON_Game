using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 左右控制
    /// </summary>
    public class PlayerControler2 : MonoBehaviour
    {
        public float speed = 20;
        public float Hinput;

        private void Update()
        {
            Hinput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * Time.deltaTime * Hinput * speed);
        }
    }
}
