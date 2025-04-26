using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
       
    }

    private void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 4, -1);

        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        //rigid.AddTorque(Vector3.up);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube")
        {
           rigid.AddForce(Vector3.up*2, ForceMode.Impulse);
        }
    }
    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
