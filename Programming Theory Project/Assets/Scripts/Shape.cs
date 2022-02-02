using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    protected string m_name;
    public string Name {get{return m_name;}}
    [SerializeField]
    protected float m_Rotation_Speed;
    public float RotationSpeed {get{return m_Rotation_Speed;}}
    [SerializeField]
    protected Color m_color;
    public Color Color {get{return m_color;} set{m_color = value;}}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        Rotate();
        OriginalMove();
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
    }

    private void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color;
    }

    protected abstract void OriginalMove();

    public static Vector3 OscillationTarget(float rangeX, float rangeY, float rangeZ)
    {
        float targetX = Mathf.Sin(Time.time) * rangeX;
        float targetY = Mathf.Sin(Time.time) * rangeY;
        float targetZ = Mathf.Sin(Time.time) * rangeZ;
        return new Vector3(targetX,targetY,targetZ);
    }
}
