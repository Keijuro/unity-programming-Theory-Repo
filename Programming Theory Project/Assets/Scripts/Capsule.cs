using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    [SerializeField]
    private float m_RangeX = 1.0f;
    public float RangeX {get{return m_RangeX;}}
    // Start is called before the first frame update
    void Start()
    {
        m_name = "Capsule";
        m_Rotation_Speed = 50.0f;
        m_color = Color.yellow;
    }

    protected override void OriginalMove()
    {
        float targetX = RangeX * Mathf.Sin(Time.time);
        Vector3 target = new Vector3(targetX,0,0);
        transform.Translate(target * Time.deltaTime, Space.World);
    }
}
