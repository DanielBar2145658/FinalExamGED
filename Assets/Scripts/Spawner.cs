using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator SpawnObject() 
    {
        yield return new WaitForSeconds(0.5f);

        int range = Random.Range(0, 99);
        GameObject Tetrimino = ObjectPooling.objectPooling.GetPooledObject(range);

        Tetrimino.transform.position = gameObject.transform.position;
        Tetrimino.SetActive(true);

        Gamemanager.Instance.characterController.bind(Tetrimino);

        


    }



}
