using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape // INHERITANCE
{
    [SerializeField]
    private float m_RangeX = 1.0f;
    public float RangeX {get{return m_RangeX;}} // ENCAPSULATION
    // Start is called before the first frame update
    void Start()
    {
        m_name = "Capsule";
        m_Rotation_Speed = 50.0f;
        m_color = Color.yellow;
    }

    protected override void OriginalMove() // POLYMORPHISM
    {
        transform.Translate(OscillationTarget(RangeX,0,0) * Time.deltaTime, Space.World); // INHERITANCE
    }
}
