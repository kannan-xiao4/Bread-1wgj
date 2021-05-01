using System;
using UniRx;

namespace Manager
{
    public class GameManager
    {
        private ReactiveProperty<int> creamBreadScore = new ReactiveProperty<int>(0);
        private ReactiveProperty<int> redBeansBreadScore = new ReactiveProperty<int>(0);
        private ReactiveProperty<int> scrapScore = new ReactiveProperty<int>(0);
        private ReactiveProperty<int> failedScore = new ReactiveProperty<int>(0);

        public IObservable<int> CreamBreadScore => creamBreadScore;

        public IObservable<int> RedBeansBreadScore => redBeansBreadScore;

        public IObservable<int> ScrapScore => scrapScore;

        public IObservable<int> FailedScore => failedScore;

        public void AddCreamBreadScore()
        {
            creamBreadScore.Value++;
        }

        public void AddRedBeansBreadScore()
        {
            redBeansBreadScore.Value++;
        }

        public void AddScrapScore()
        {
            scrapScore.Value++;
        }

        public void AddFailedScore()
        {
            failedScore.Value++;
        }

        public void Exit()
        {
            
        }
    }
}