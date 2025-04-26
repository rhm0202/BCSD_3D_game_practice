using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.name == "My ball")
        {
            mat.color = new Color(0, 0, 0);
        }   
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My ball")
        {
            mat.color = new Color(1, 1, 1);
        }
    }
}
