using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour {

    // Plot static stuff
    public float PLOT_SIZE = 3f;

    // Cloud
    public GameObject Cloud;
    public float cloudChance;
    private float cloudHeight = 4;

    // Building
    public GameObject Building;
    public float buildingChance;

    // Trees
    public GameObject Tree;
    public float treeChance;

    // Structures
    //public GameObject[] Structures;


	// Use this for initialization
	void Start ()
    {
        // Fix grass rotation
        transform.GetChild(0).eulerAngles = new Vector3(90, 0, 0);

        // Spawn Cloud
        if(Random.Range(0f, 1f) < cloudChance)
        {
            GameObject cloud = Instantiate(Cloud, new Vector3(transform.position.x, cloudHeight, transform.position.z), Quaternion.identity, this.gameObject.transform) as GameObject;
            // Fix rotation
            cloud.transform.eulerAngles = new Vector3(90, 180, 0);
        }

        // Spawn Building
        if (Random.Range(0f, 1f) < cloudChance)
        {
            Instantiate(Building, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity, this.gameObject.transform);
        }

        // Spawn Trees!
        if (Random.Range(0f, 1f) < treeChance)
        {
            for(int i = 0; i < PLOT_SIZE+1; i++)
            {
                GameObject tree = Instantiate(Tree, new Vector3(transform.position.x + PLOT_SIZE + i, transform.position.y + 0.5f, transform.position.z + PLOT_SIZE/2), Quaternion.identity, this.gameObject.transform) as GameObject;
                // Fix rotation
                tree.transform.eulerAngles = new Vector3(90, 180, 0);

            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
