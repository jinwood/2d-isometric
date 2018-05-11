using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour 
{
	public Tile[] Tiles {get;set;}

    private void InitWorld()
    {
        Tiles = new Tile[12];

        for(var i = 0; i < Tiles.Length; i++)
        {
            Tiles[i] = new Tile(TileType.Grass);
            //Todo: positioning and render
        }
    }

    public void start()
    {
        InitWorld();
    }
}
