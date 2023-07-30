namespace Task1;

public class BirdCount
{
    List<int> _birds;
    public BirdCount(List<int> birds)
    {
        _birds = birds;
    }

    public void LastWeek()
    {
        foreach (var bird in _birds)
        {
            System.Console.Write($"{bird} ");
        }
    }

    public int Today()
    {
        return _birds.LastOrDefault();
    }
    public int IncrementTodaysCount()
    {
        return _birds.LastOrDefault()+1;
    }
    public bool HasDayWithoutBirds(){
        foreach (var bird in _birds)
        {
            if(bird==0){
                return true;
            }
        }
        return false;
    }
    public int BirdCountSum()
    {
        int sum=0;
        for (int i = 0; i < 4; i++)
        {
            sum+=_birds[i];
        }
        return sum;
    }
    public int BusyDays()
    {
        int cnt=0;
        foreach (var bird in _birds)
        {
            if (bird>=5)
            {
                cnt++;
            }
        }
        return cnt;
    }
}