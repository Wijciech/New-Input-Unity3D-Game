using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggs : MonoBehaviour
{
    private Wolf _wolf;
    private void Awake()
    {
        _wolf = GameObject.Find("Wolf").GetComponent<Wolf>();
    }

private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wolf")
        {
            _wolf.AddScore(1);
            Destroy(this.gameObject);
        }
        else if (other.tag == "Wall")
        {
            _wolf.Removelives();
            Destroy(this.gameObject);
        }
    }
}
