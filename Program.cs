using Task1;

var birds = new List<int>(){ 0, 2, 5, 3, 7, 8, 4};

var birdCount = new BirdCount(birds);
birdCount.LastWeek();
System.Console.WriteLine();
System.Console.WriteLine(birdCount.Today());
System.Console.WriteLine(birdCount.IncrementTodaysCount());
System.Console.WriteLine(birdCount.HasDayWithoutBirds());
System.Console.WriteLine(birdCount.BirdCountSum());
System.Console.WriteLine(birdCount.BusyDays());