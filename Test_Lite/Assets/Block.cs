using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public GameObject Plot;
    public int blockSize; // How many plots per side

	void Start () {

        buildBlock();

	}

    void buildBlock()
    {
        float plot_size = Plot.GetComponent<Plot>().PLOT_SIZE;
        int x = 0;
        int y = 0;

        // Generate grid of plots
        for (int i = 0; i < 100; i++)
        {
            buildPlot(Plot, x * (int)plot_size, y * (int)plot_size);

            x++;
            if (x > 9)
            {
                y++;
                x = 0;
            }
        }
    }

    void buildPlot(GameObject Plot, int x, int y)
    {
        Instantiate(Plot, new Vector3(x, 0, y), Quaternion.identity);
    }
	
	void Update () {
		

	}
}
