using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : Singleton<GameManager>
{
    public static GameManager instance;
    public int[,] currMap;
    public int width = 50;
    public int height = 50;
    public int lengthMap = 100;
    public int seed = 0;
    TileMap tileMapScript;
    
    void Start()
    {
        //locate and assign the tilemapscript
        tileMapScript = GameObject.Find("Floor").GetComponent<TileMap>();
        //generate the map
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void GenerateMap()
    {
        currMap = new MapGenerator().makeMap(width, height, lengthMap, 0);
        tileMapScript.RenderTile(currMap);
        
    }


}
