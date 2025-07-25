using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    private Camera camera;
    private GameManager gameManager;

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;
        camera = Camera.main;
    }

    void OnMove(InputValue inputValue)
    {
        //movementDirection = inputValue.Get<Vector2>();
        //movementDirection = movementDirection.normalized;
        movementDirection = inputValue.Get<Vector2>().normalized;
    }
}
