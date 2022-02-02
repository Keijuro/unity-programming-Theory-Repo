using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    [SerializeField]
    private float m_RangeZ = 10.0f;
    public float RangeZ {get{return m_RangeZ;}} // ENCAPSULATION
    // Start is called before the first frame update
    void Start()
    {
        m_name = "Sphere";
        m_Rotation_Speed = 15.0f;
        m_color = Color.red;
    }

    protected override void OriginalMove() // POLYMORPHISM
    {
        transform.Translate(OscillationTarget(0,0,RangeZ) * Time.deltaTime, Space.World); // INHERITANCE
    }
}
