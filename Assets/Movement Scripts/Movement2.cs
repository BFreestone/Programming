using UnityEngine;
using System;

namespace Debugging.Player

{
    [AddComponentMenu("RPG/Player/Movement")]
    [RequireComponent(typeof(CharacterController))]
    public class Movement2 : MonoBehaviour
    {
        [Header("Speed Vars")]
        public float moveSpeed;
        public float walkSpeed = 5, runSpeed = 10, crouchSpeed = 2.5f, jumpSpeed = 8;
        private float _gravity = 20.0f;
        private Vector3 _moveDir;
        [SerializeField] private CharacterController _charC;
        private void Start()
        {
            _charC = GetComponent<CharacterController>();
        }
 
        private void Update()
        {
            Move();
        }
        private void Move()
        {
            if (_charC.isGrounded)
            {
                if (Input.GetButton("Sprint"))
                {
                    moveSpeed = runSpeed;
                }
                else if (Input.GetButton("Crouch"))
                {
                    moveSpeed = crouchSpeed;
                    _charC.height = 1;
                }
                else
                {
                    moveSpeed = walkSpeed;
                    _charC.height = 2;
                }
                _moveDir = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed);
                if (Input.GetButton("Jump"))
                {
                    _moveDir.y = jumpSpeed;
                }
            }
            _moveDir.y -= _gravity * Time.deltaTime;
            _charC.Move(_moveDir * Time.deltaTime);
        }

    }
}
