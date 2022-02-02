using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        m_name = "Cube";
        m_Rotation_Speed = 50.0f;
        m_color = Color.blue;
    }

    protected override void OriginalMove()
    {
        transform.Translate(OscillationTarget(0,1,0) * Time.deltaTime);
    }

}
