
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float MoveSpeed = 10f;
   
    void Start()
    {
        printInstructions();
    }

     void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, 0f, zValue);
    }
    void printInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("You can move your player by using WASD keys");
    }
}
