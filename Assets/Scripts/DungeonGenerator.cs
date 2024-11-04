using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public GameObject[] roomPrefabs;
    public int gridWidth = 5;
    public int gridHeight = 5;
    public float roomSpacing = 10.0f;

    private void Start()
    {
        GenerateDungeon();
    }

    private void GenerateDungeon()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                Vector3 position = new Vector3(x * roomSpacing, y * roomSpacing, 0);
                GameObject roomPrefab = roomPrefabs[Random.Range(0, roomPrefabs.Length)];
                Instantiate(roomPrefab, position, Quaternion.identity);
            }
        }
    }
}