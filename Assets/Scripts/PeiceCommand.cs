using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeiceCommand : ICommand
{
    public PeiceController peiceController;
    
    public void Move(Vector2 vector2)
    {
        peiceController.Move(vector2);
    }

    public void RotateLeft(float angle)
    {
        peiceController.Rotate(angle);
    }

    public void RotateRight(float angle)
    {
        peiceController.Rotate(angle);
    }
}
