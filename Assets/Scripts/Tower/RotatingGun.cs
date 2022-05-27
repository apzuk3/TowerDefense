using UnityEngine;

public class RotatingGun : MonoBehaviour
{
    public float speed = 60.0f;

    public bool m_shooting = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (m_shooting)
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
    }


    public void Shooting()
    {
        m_shooting = true;
    }

    public void Hold()
    {
        transform.rotation =  Quaternion.Euler(0, 0, 0);

        m_shooting = false;
    }
}
