using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    int kecepatan = 10;
    public Vector2 arah;
    public Vector2 mouse;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.ScoreValue < 50)
        {
            mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            mouse.x = Mathf.Clamp(Input.GetAxis("Mouse X"), -3, 3) * kecepatan;
            mouse.y = Mathf.Clamp(Input.GetAxis("Mouse Y"), -3, 3) * kecepatan;
            arah.x = Input.GetAxis("Horizontal") * kecepatan;
            arah.y = Input.GetAxis("Vertical") * kecepatan;
            //rigidbody.MovePosition(rigidbody.position + (arah + mouse) * kecepatan * Time.fixedDeltaTime);
            rigidbody.velocity = arah + mouse;
        }
        else
        {
            rigidbody.velocity = new Vector2(0,0);
        }
    }
}
