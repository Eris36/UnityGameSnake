using System.Collections.Generic;
using UnityEngine;

namespace GameSnake
{
    public class Snake : MonoBehaviour
    {
        [SerializeField] private List<Transform> _tails;
        [SerializeField] private float _bonesDistantice;
        [SerializeField] private GameObject _bonePrefab;
        [Range(0, 4), SerializeField] private float _moveSpeed;
        [Range(0, 100), SerializeField] private float _rotatrSpeed;
        
        // Update is called once per frame
        private void Update()
        {
            MoveHead(_moveSpeed);
            MoveTail();
            Rotate(_rotatrSpeed);
        }
    
        private void MoveHead(float speed)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
    
        private void MoveTail()
        {
            float sqrDistance = Mathf.Sqrt(_bonesDistantice);
            Vector3 previousPosition = transform.position;
            foreach (var bone in _tails)
            {
                if ((bone.position - previousPosition).sqrMagnitude > sqrDistance)
                {
                    Vector3 currentBonePosition = bone.position;
                    bone.position = previousPosition;
                    previousPosition = currentBonePosition;
                }
                else
                {
                    break;
                }
            }
        }
    
        private void Rotate(float speed)
        {
            float angle = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Rotate(0, angle,0);
        }
    
        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Food food))
            {
                Destroy(other.gameObject);
                GameObject bone = Instantiate(_bonePrefab);
                _tails.Add(bone.transform);
            }
        }
    }

}



























