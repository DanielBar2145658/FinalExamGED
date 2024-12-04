using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    public Spawner spawner;

    public CharacterControlls characterController;
    internal int score;

    public static Gamemanager Instance { get; set; }


    private void Awake()
    {
        characterController = FindObjectOfType<CharacterControlls>();
        spawner = FindObjectOfType<Spawner>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);

        }
        else 
        {
            Instance = this;
        
        }
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
