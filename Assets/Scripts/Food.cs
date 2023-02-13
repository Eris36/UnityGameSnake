using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSnake
{
    public class Food : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
           
            }
    }
}
}
