using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace BlackNWhiteShooter.Manager
{
    public class BoardManager : MonoBehaviour
    {
        [Serializable]
        public class Range
        {
            public int minimum;
            public int maximum;

            public Range(int min, int max)
            {
                minimum = min;
                maximum = max;
            }
        }

        public int columns = 8;
        public int rows = 8;
        public GameObject[] floorTiles;

        private Transform boardHolder;

        void BoardSetup()
        {
            boardHolder = new GameObject("Board").transform;

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    GameObject toInstantiate = floorTiles[Random.Range(0, floorTiles.Length)];
                    GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(boardHolder);
                }
            }
        }

        public void SetupScene()
        {
            BoardSetup();
        }
    }
}
