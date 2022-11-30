using UnityEngine;

namespace GLORY
{
    /// <summary>
    /// 移動系統
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            // transform 此物件的 Transform 元件
            // Translate(x, y, z) 位移
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}