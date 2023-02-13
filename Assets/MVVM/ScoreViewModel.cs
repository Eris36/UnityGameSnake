using System;

namespace GameSnake
{
    internal sealed class ScoreViewModel : IScoreViewModel
    {
        private bool _isVin;
        public event Action<float> OnScoreChange;
        public IScoreModel ScoreModel { get; }
        public bool IsVin => _isVin;

        public ScoreViewModel(IScoreModel scoreModel)
        {
            ScoreModel = scoreModel;
        }

        public void AddScore(float score)
        {
            ScoreModel.CurrentScore += score;
            if (ScoreModel.CurrentScore >= 10)
            {
                _isVin = true;
            }
            OnScoreChange?.Invoke(ScoreModel.CurrentScore);
        }
        
    } 
}

