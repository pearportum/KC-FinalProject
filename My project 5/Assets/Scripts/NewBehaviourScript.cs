using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody { get; private set;}
    public float speed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SetRandomTrajectory), 0.5f);
    }
    void SetRandomTrajectory()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        this.rigidbody.AddForce(force.normalized * this.speed);
    }

}
