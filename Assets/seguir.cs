using UnityEngine;

public class seguir : MonoBehaviour
{
    public Transform cube;
    public Vector3 distancia;
    void Update()
    {
        transform.position = cube.position+distancia;
    }
}
