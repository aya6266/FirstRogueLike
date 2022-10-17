using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 class MapGenerator : MonoBehaviour 
{
    private HashSet<Vector2Int> visted = new HashSet<Vector2Int>();
    public int[,] makeMap(int width, int height, int lengthMap, int seed)
    {
        Random.InitState(seed);
        
        Vector2Int startPos = new Vector2Int(Random.Range(0,width), Random.Range(0,height));
        int[,] map = new int[width, height];
        
        while(lengthMap > 0)
        {
            Vector2Int randomDir = randomDirection(Random.Range(0, 4));
            startPos += randomDir;
            if(!visted.Contains(startPos) && newDirectionInMap(startPos, width, height))
            {
                map[startPos.x, startPos.y] = 1;
                visted.Add(startPos);
                lengthMap--;
            }
            
            else
            {
                startPos -= randomDir;
            }    
        }
        return map;    
    }

    private Vector2Int randomDirection(int random)
    {
        switch(random)
        {
            case 0:
                return new Vector2Int(0, 1);
            case 1:
                return new Vector2Int(0, -1);
            case 2:
                return new Vector2Int(1, 0);
            case 3:
                return new Vector2Int(-1, 0);
            default:
                return new Vector2Int(0, 0);
        }
    }
    private bool newDirectionInMap(Vector2Int newPos, int width, int height)
    {
        return newPos.x >= 0 
        && newPos.x < width 
        && newPos.y >= 0 
        && newPos.y < height;
    }
    
}