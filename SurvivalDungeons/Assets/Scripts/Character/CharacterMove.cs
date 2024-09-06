using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMove : MonoBehaviour, IMoveable
{
    [SerializeField] private CharacterController characterController;

    [SerializeField] private FloatingJoystick joystick;

    [SerializeField] private float speedMove;

    [SerializeField] private Vector3 move;
    public void Update()
    {
        move = new Vector3(joystick.Direction.x, 0f, joystick.Direction.y);

        if (joystick.Direction.x != 0f || joystick.Direction.y != 0f)
            Move();
        else
            Idle();

    }
    public void Idle()
    {
        Debug.Log("i'm idle");
    }

    public void Move()
    {
        characterController.Move((move * speedMove) * Time.deltaTime);

        Quaternion targetRotation = Quaternion.LookRotation(move);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f); // Плавное вращение

        Debug.Log("i'm move");
    }
}
