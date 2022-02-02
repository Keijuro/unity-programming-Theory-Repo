using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    [SerializeField]
    private float m_RangeZ = 10.0f;
    public float RangeZ {get{return m_RangeZ;}}
    // Start is called before the first frame update
    void Start()
    {
        m_name = "Sphere";
        m_Rotation_Speed = 15.0f;
        m_color = Color.red;
    }

    protected override void OriginalMove()
    {
        float targetZ = RangeZ * Mathf.Sin(Time.time);
        Vector3 target = new Vector3(0,0,targetZ);
        transform.Translate(target * Time.deltaTime, Space.World);
    }
}
