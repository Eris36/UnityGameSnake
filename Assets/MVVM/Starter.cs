using UnityEngine;

namespace GameSnake
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private ScoreView _scoreView;
        [SerializeField] private ApplyScoreView _applyScoreView;
        [SerializeField] private GameObject food;
        

        private void Start()
        {
            var scoreModel = new ScoreModel(0);
            var scoreViewModel = new ScoreViewModel(scoreModel);
            _scoreView.Initialize(scoreViewModel);
            _applyScoreView.Initialize(scoreViewModel);
        }

        public void NewPositionFood()
        {
            food.transform.position = new Vector3( Random.Range(-18, 18), 1, Random.Range(1, 38) );
        }
    }
}

