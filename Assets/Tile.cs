using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour 
{
	public TileType TileType {get;set;}

	public Tile(TileType type)
	{
		this.TileType = type;

		switch(this.TileType)
		{
			case TileType.Grass:
				//set the tile colour
				break;	
			default:
				return;
		}
	}
}

public enum TileType
{
	Unknown = 0,
	Grass = 1
}