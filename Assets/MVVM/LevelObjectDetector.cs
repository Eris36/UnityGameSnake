using System;
using UnityEngine;

namespace GameSnake
{
    public class LevelObjectDetector : MonoBehaviour
    {
        public Action TriggerEnter;

        public Action TriggerExit;

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Snake>())
            {
                TriggerEnter?.Invoke();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if(other.GetComponent<Snake>())
                TriggerExit?.Invoke();
        }
    }
}

