using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameSnake
{
    public class ApplyScoreView : MonoBehaviour
    {
        [SerializeField] private float _score;
        public IScoreViewModel _scoreViewModel;
        [SerializeField] private LevelObjectDetector _levelObjectDetector;
        
        
        
        public void Initialize( IScoreViewModel scoreViewModel)
        {
            _scoreViewModel = scoreViewModel;
            _levelObjectDetector.TriggerEnter += () => _scoreViewModel.AddScore(_score);
        }
    }
}
