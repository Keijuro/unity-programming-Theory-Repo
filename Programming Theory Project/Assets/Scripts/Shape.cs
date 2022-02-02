using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    protected string m_name;
    public string Name {get{return m_name;}} // ENCAPSULATION
    [SerializeField]
    protected float m_Rotation_Speed;
    public float RotationSpeed {get{return m_Rotation_Speed;}} // ENCAPSULATION
    [SerializeField]
    protected Color m_color;
    public Color Color {get{return m_color;} set{m_color = value;}} // ENCAPSULATION

    // Update is called once per frame
    void Update() // INHERITANCE
    {
        ChangeColor();
        Rotate();
        OriginalMove(); // POLYMORPHISM
    }

    private void Rotate() // ABSTRACTION
    {
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
    }

    private void ChangeColor() // ABSTRACTION
    {
        GetComponent<MeshRenderer>().material.color = Color;
    }

    protected abstract void OriginalMove(); // POLYMORPHISM

    public static Vector3 OscillationTarget(float rangeX, float rangeY, float rangeZ) // ABSTRACTION
    {
        float targetX = Mathf.Sin(Time.time) * rangeX;
        float targetY = Mathf.Sin(Time.time) * rangeY;
        float targetZ = Mathf.Sin(Time.time) * rangeZ;
        return new Vector3(targetX,targetY,targetZ);
    }
}
