namespace GameSnake
{
    public interface IScoreModel
    {
        float MaxScore { get; }
        float CurrentScore { get; set; }
    }
}