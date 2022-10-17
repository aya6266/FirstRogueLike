using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMap : MonoBehaviour
{
    private Tilemap floor;
    public TileBase floorTile;
    
    // Start is called before the first frame update
    void Awake()
    {
        floor = gameObject.GetComponent<Tilemap>();
        
        
    }

    public void RenderTile(int[,] map)
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == 1)
                {
                    floor.SetTile(new Vector3Int(i, j, 0), floorTile);
                }
            }
        }
    }
}
