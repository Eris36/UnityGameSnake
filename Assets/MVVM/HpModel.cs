namespace GameSnake
{
    internal sealed class ScoreModel : IScoreModel
    {
        public float CurrentScore { get; set; }
        
        
        public ScoreModel(float score)
        {
            CurrentScore = score;
        } 
    }
}