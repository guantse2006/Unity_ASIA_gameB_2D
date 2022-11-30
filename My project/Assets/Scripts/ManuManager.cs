using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace GLORY
{
    /// <summary>
    /// 選單管理器
    /// </summary>
    public class ManuManager : MonoBehaviour
    {
        /// <summary>
        /// 開始遊戲
        /// </summary>
        private Button btnplay;

        private void Awake()
        {
            btnplay = GameObject.Find("開始遊戲").GetComponent<Button>();
            btnplay.onClick.AddListener(StartGame);
        }

        /// <summary>
        /// 開始遊戲
        /// </summary>
        private void StartGame()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}