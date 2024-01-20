using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float Speed = 0.01f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float SpeedX = Input.GetAxis("Horizontal");
        Debug.Log(SpeedX);
        transform.Translate(SpeedX * Speed, 0, 0);
    }
}
