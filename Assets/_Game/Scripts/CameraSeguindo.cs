using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguindo : MonoBehaviour
{
    private Transform playerTransform;

    [SerializeField] private float deslocamento;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(playerTransform.position.x + deslocamento, this.transform.position.y, this.transform.position.z);
    }
}
