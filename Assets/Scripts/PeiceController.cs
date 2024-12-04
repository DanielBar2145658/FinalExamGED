using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeiceController : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector2 vector2)
    {
        rb.AddForce(vector2, ForceMode.Force);
    
    }

    public void Rotate(float angle)
    {
        gameObject.transform.Rotate(gameObject.transform.position, angle);
    
    
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground")) 
        {
            StartCoroutine(Gamemanager.Instance.spawner.SpawnObject());
            gameObject.tag = "Ground";
            Gamemanager.Instance.characterController.unBind();
            Gamemanager.Instance.score += 100;
        }
    }


}
