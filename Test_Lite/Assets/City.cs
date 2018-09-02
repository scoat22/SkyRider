using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public GameObject Block; // grab blockSize
    public int blockCount;
    private GameObject[] blocks;

    void Start()
    {
        initArray(blocks, blockCount);
    }

    void Update()
    {
        int i = 0;
        calcNextBlock(i);
    }

    void calcNextBlock(int currBlock)
    {
        // Re-generate current block
        blocks[currBlock].SendMessage("buildBlock");

        // Track player x, move current block to location
        blocks[currBlock].transform.position = new Vector3();
        
    }

    void initArray(GameObject[] blocks, int size)
    {
        blocks = new GameObject[size];
    }
}
