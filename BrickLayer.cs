using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickLayer : MonoBehaviour
{
    public float x_Start, y_Start;

    public int columLength, rowLength;
    public float x_Space, y_Space;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < columLength * rowLength; i++)
        {
            Instantiate(prefab, new Vector3(x_Start + (x_Space * (i %columLength)), y_Start + (-y_Space * (i / columLength))), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
