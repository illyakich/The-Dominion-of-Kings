Console.WriteLine("hey King, how many estates, duchies and provinces do you have? (write in the 1, 2, 3 format");
int ME, MD, MP;
ME = Convert.ToInt32(Console.ReadLine());
MD = Convert.ToInt32(Console.ReadLine());
MP = Convert.ToInt32(Console.ReadLine());

MD = MD * 3;
MP = MP * 6;
int TotalM = ME + MD + MP;

Console.WriteLine($"You got {TotalM} points total");