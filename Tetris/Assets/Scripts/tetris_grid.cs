using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.GameClasses;

public class tetris_grid : MonoBehaviour {

    public int gridWidth = 10;
    public int gridHeight = 20;

    public float offsetX = (float)0.5;
    public float offsetY = (float)0.5;

    private TetrisGameGrid myGrid; //default is null, instantiated by start()

    public GameObject blockBlue;
    public GameObject blockGreen;
    public GameObject blockIndigo;
    public GameObject blockWhite;
    public GameObject blockYellow;
    public GameObject blockRed;
    public GameObject blockOrange;
    
	void Start () {
        myGrid = new TetrisGameGrid(gridWidth, gridHeight);

        myGrid.gridSpaces[0, 0] = new Block(0, 0, BlockColor.Green);
        myGrid.gridSpaces[5, 2] = new Block(5, 2, BlockColor.Red);
        myGrid.gridSpaces[1, 0] = new Block(1, 0, BlockColor.Blue);
        myGrid.gridSpaces[0, 1] = new Block(0, 1, BlockColor.Yellow);
        myGrid.gridSpaces[1, 1] = new Block(1, 1, BlockColor.Indigo);
        myGrid.gridSpaces[1, 2] = new Block(1, 2, BlockColor.Orange);
        myGrid.gridSpaces[2, 2] = new Block(2, 2, BlockColor.White);
    }
	
	// Update is called once per frame
	void Update () {
        /*foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Placeholder"))
        {
            Destroy(obj);
        }*/
        // todo: delete all block placeholders already on the board
		foreach(Block block in myGrid.gridSpaces)
        {
            if(block != null)
            {
                float blockX = block.x;
                float blockY = block.y;
                if (block.color == BlockColor.Blue)
                {
                    Instantiate(blockBlue, new Vector2(blockX + offsetX, blockY + offsetY), new Quaternion(0, 0, 0, 0));
                }
                else if (block.color == BlockColor.Green)
                {
                    Instantiate(blockGreen, new Vector2(blockX + offsetX, blockY + offsetY), new Quaternion(0, 0, 0, 0));
                }
                else if (block.color == BlockColor.Red)
                {
                    Instantiate(blockRed, new Vector2(blockX + offsetX, blockY + offsetY), new Quaternion(0, 0, 0, 0));
                }
                else if (block.color == BlockColor.Orange)
                {
                    Instantiate(blockOrange, new Vector2(blockX + offsetX, blockY + offsetY), new Quaternion(0, 0, 0, 0));
                }
                else if (block.color == BlockColor.Yellow)
                {
                    Instantiate(blockYellow, new Vector2(blockX + offsetX, blockY + offsetY), new Quaternion(0, 0, 0, 0));
                }
                else if (block.color == BlockColor.Indigo)
                {
                    Instantiate(blockIndigo, new Vector2(blockX + offsetX, blockY + offsetY), new Quaternion(0, 0, 0, 0));
                }
                else if (block.color == BlockColor.White)
                {
                    Instantiate(blockWhite, new Vector2(blockX + offsetX, blockY+ offsetY), new Quaternion(0, 0, 0, 0));
                }
            }
        }
	}
}
