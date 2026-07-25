using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float MoveSpeed = 10f;
   
    void Start()
    {
        
    }

     void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, 0f, zValue);
    }
}
