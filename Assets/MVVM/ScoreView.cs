using UnityEngine;
using UnityEngine.UI;

namespace GameSnake
{
    internal sealed class ScoreView: MonoBehaviour
    {
        [SerializeField] private Text _text;
        private IScoreViewModel _scoreViewModel;

        public void Initialize(IScoreViewModel scoreViewModel)
        {
            _scoreViewModel = scoreViewModel;
            _scoreViewModel.OnScoreChange += OnScoreChange;
            OnScoreChange(_scoreViewModel.ScoreModel.CurrentScore);
        }

        private void OnScoreChange(float currentScore)
        {
            _text.text = _scoreViewModel.IsVin ? "10 Победа!" : currentScore.ToString();
        }

        ~ScoreView()
        {
            _scoreViewModel.OnScoreChange -= OnScoreChange;
        }
    }
}


