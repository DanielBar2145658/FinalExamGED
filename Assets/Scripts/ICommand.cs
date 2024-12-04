using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void Move(Vector2 vector2);

    void RotateLeft(float quaternion);


    void RotateRight(float quaternion);

    ICommand Bind() 
    {
        return this;
    
    }
}
