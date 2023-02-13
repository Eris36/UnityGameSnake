using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSnake
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private ScoreView _scoreView;
        [SerializeField] private ApplyScoreView _applyScoreView;

        private void Start()
        {
            var scoreModel = new ScoreModel(0);
            var scoreViewModel = new ScoreViewModel(scoreModel);
            _scoreView.Initialize(scoreViewModel);
            _applyScoreView.Initialize(scoreViewModel);
        }
    }
}

