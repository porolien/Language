using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{

    public PlayerInputs playerInput;
    public PlayerMovement playerMovement;
    public CharacterController controller;
    // Start is called before the first frame update
    void Awake()
    {
        SendMessage("Init", this);        
        controller = GetComponent<CharacterController>();
    }    
}
