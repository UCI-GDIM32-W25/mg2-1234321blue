using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D _playerRB;
    [SerializeField] float _jump;
    bool _isGrounded=true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("testing");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&_isGrounded)
        {
            _playerRB.AddForce(Vector2.up*_jump,ForceMode2D.Impulse);
            _isGrounded=false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded=true;
        }
    }
}
