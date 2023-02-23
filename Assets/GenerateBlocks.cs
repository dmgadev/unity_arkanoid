using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocks : MonoBehaviour
{
    public GameObject block0;
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject concrete_block;
    
    void Start()
    {
        Quaternion self_quatertion = Quaternion.AngleAxis(0, new Vector3(0, 0, 0));
        Vector3 crystal_pos = new Vector3(0, 0, 0);
        crystal_pos.x = -4f;
        crystal_pos.y = 3;
        for (int i = 0; i < 4; i++)
        {
            crystal_pos.x = -4f;
            for (int j = 0; j < 4; j++)
            {
                int rand = Random.Range(0, 5);
                if (rand == 0)
                {
                    Instantiate(block0, crystal_pos, self_quatertion);
                }
                if (rand == 1)
                {
                    Instantiate(block1, crystal_pos, self_quatertion);
                }
                if (rand == 2)
                {
                    Instantiate(block2, crystal_pos, self_quatertion);
                }
                if (rand == 3)
                {
                    Instantiate(block3, crystal_pos, self_quatertion);
                }
                if (rand == 4)
                {
                    Instantiate(concrete_block, crystal_pos, self_quatertion);
                }
                crystal_pos.x = crystal_pos.x + 2.75f;
            }
            crystal_pos.y = crystal_pos.y - 1.2f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
