using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameSnake
{
    public class ApplyScoreView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _score;
        public IScoreViewModel _scoreViewModel;

        private bool test;


        public void Initialize( IScoreViewModel scoreViewModel)
        {
            _scoreViewModel = scoreViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _scoreViewModel.AddScore(_score));
        }
    }
}
