﻿using UnityEngine;

namespace BlackNWhiteShooter.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance = null;
        private BoardManager boardScript;

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

            boardScript = GetComponent<BoardManager>();

            InitGame();
        }

        void InitGame()
        {
            boardScript.SetupScene();
        }
    }
}
