using System;

namespace GameSnake
{
    public interface IScoreViewModel
    {
       IScoreModel ScoreModel { get; }
       bool IsVin { get; }
       void AddScore(float score);
       event Action<float> OnScoreChange;
    }
}

