namespace GameSnake
{
    internal sealed class ScoreModel : IScoreModel
    {
        public float MaxScore { get; }
        public float CurrentScore { get; set; }
        
        
        public ScoreModel(float score)
        {
            CurrentScore = score;
        } 
    }
}

