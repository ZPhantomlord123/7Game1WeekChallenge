using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float pipeGap = 0.2f;
    public float pipeSpeed = 0.5f;
    private void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position,new Vector2(transform.position.x-pipeSpeed,transform.position.y),pipeGap);
    }
}
