
// 1-topshiriq 

Console.WriteLine("Radius=");
int radius = Convert.ToInt16(Console.ReadLine());
double S = 3.14*radius*radius;
double L = 2 * 3.14 * radius;
Console.WriteLine($"Output: S={S}, L={L}");


// 2-topshiriq 

Console.Write("Input: qiymat=");
double amount = Convert.ToDouble(Console.ReadLine());
Console.Write("kurs=");
double exchange_Rate = Convert.ToDouble(Console.ReadLine());
double converted_Amount = amount * exchange_Rate;
Console.WriteLine($"Output: {converted_Amount} so'm");


// 3-topshiriq

Console.Write("Input: x=");
int birth_Year = Convert.ToInt32(Console.ReadLine());
int current_Year = DateTime.Now.Year;
int age_In_Days = (current_Year - birth_Year) * 365;
Console.WriteLine($"Output: {age_In_Days}");