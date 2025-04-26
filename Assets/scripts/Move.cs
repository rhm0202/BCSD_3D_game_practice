using UnityEngine;

public class Move : MonoBehaviour
{

    Vector3 target = new Vector3(0, 1.5f, 9);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position =
        //    Vector3.MoveTowards(transform.position, target, 2f);

        //Vector3 velo = Vector3.zero;

        //transform.position =
        //    Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //transform.position =
        //    Vector3.Lerp(transform.position, target,  0.05f);

        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }
}
