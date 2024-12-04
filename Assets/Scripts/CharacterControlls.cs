using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlls : MonoBehaviour
{

    PeiceCommand peiceComand;

    Vector2 direction;

    PeiceController currentPeice;

    // Start is called before the first frame update
    void Start()
    {
        peiceComand = new PeiceCommand();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {

            peiceComand.Move(new Vector2(-5,0));
        
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            peiceComand.Move(new Vector2(5, 0));

        }
        if (Input.GetKeyDown(KeyCode.Z))
        {

            peiceComand.RotateLeft(90);

        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            peiceComand.RotateRight(-90);

        }
    }


    public void bind(GameObject gameObject) 
    {
        currentPeice = gameObject.GetComponent<PeiceController>();
    
    }
    public void unBind() 
    {
        currentPeice = null;
    }



}
