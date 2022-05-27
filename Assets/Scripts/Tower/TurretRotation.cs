using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public float speed = 10.0f;

    private bool m_stopped = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!m_stopped)
        {
            transform.RotateAround(transform.position, Vector3.up, speed * Time.deltaTime);
        }
    }

    public void Hold()
    {
        m_stopped = false;
    }

    public void Rotate()
    {
        m_stopped = true;
    }
}
