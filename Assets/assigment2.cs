using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assigment2 : ProcessingLite.GP21
{
        float x;
        float y1;

    void Start()
    {     
        Background(0);
    }
    void Update()
    {
        float spaceBetweenLines = 0.7f;
        StrokeWeight(0.7f);
        float lines = 30;

        for (int i = 0; i < lines; i++)
        {   
            float y = i * spaceBetweenLines;

            //changes colour
            if (i % 3== 0)
            {
                Stroke(219, 112, 147);      
            }

            else
            {
                Stroke(255, 255, 0);
            }

            Line(x + y, y1, 20.5f, y1 + y);
        }

    }
}
