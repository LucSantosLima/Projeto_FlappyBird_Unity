using UnityEngine;

public class ObstacleMoviment : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        obstacleMovement();
    }

    void obstacleMovement(){
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
