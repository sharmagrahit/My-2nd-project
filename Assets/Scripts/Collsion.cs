using Unity.VisualScripting;
using UnityEngine;

public class Collsion : MonoBehaviour
{
void OnCollisionEnter(Collision other)
    {
         GetComponent<MeshRenderer>().material.color =Color.red;
    }
}

