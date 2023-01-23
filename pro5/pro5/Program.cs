Console.WriteLine("write a dob");
DateTime dob= Convert.ToDateTime(Console.ReadLine());
TimeSpan ts1 = DateTime.Now -dob;
Console.WriteLine("days is " + ts1.Days);
Console.WriteLine("min:"+ts1.Days*60*60);
Console.WriteLine("sec:"+ts1.Seconds);
Console.WriteLine("milsec:"+ts1.Milliseconds);
Console.WriteLine("year:"+ts1.Days / 365);
Console.WriteLine("month:"+ts1.Days / 30);
