using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody player;

    private float xDeg = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float eixoX = Input.GetAxis("Vertical") * -5;
        float eixoZ = Input.GetAxis("Horizontal") * 5;

        player.velocity = new Vector3(eixoX, player.velocity.y, eixoZ);

        if (Input.GetButtonDown("Jump"))
        {
            player.AddForce(Vector3.up * 50);
        }

        xDeg += Input.GetAxis("Mouse X") * 1;
        player.rotation = Quaternion.Euler(0, xDeg, 0);
    }
}
