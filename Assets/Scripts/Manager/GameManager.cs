using UnityEngine;

namespace BlackNWhiteShooter.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance = null;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            else if (instance != this)
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);

            InitGame();
        }

        void InitGame()
        {
        }
    }
}
