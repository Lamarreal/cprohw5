using cprohw5;

Thermostat thermostat = new Thermostat();

void tempChanged(double newTemp)
{
    Console.WriteLine(newTemp);
}

thermostat.TemperatureChanged += tempChanged;

thermostat.Temperature = 3;

//---------------------------------------------------------------------
Console.Write("Enter your number >");
int input = 5;
try
{
    input = Convert.ToInt16(Console.ReadLine()?.ToString());
}
catch
{

}

int userNumber = input;
int[] list =  new int[] {1,2,4,5,6,9,1,3,5,6};
int[] list2 = new int[] { 1,9, 9, 9, 9, 9, 9, 9, 9, 6 , 1, 2, 4, 5, 6, 9, 1, 3, 5, 6 };


var filter1 = (int x) => x % 2 == 0;
var filter2 = (int a,int b) => a > b;

foreach (int x in list)
{
    Console.WriteLine(filter1(x) ? " {0} is double" : " {0} is not double", x);
}
Console.WriteLine();
foreach (int x in list)
{
    Console.WriteLine(" {0} {2} than {1}", x, userNumber, filter2(x, userNumber) ? "greater" : "less");
}

Console.WriteLine("Average: " + Tools.Average(list2).ToString());

Sensor sensor = new Sensor();

sensor.AddMeasurement(10);
sensor.AddMeasurement(10);

void OnChangedAvg(double avg)
{
    Console.WriteLine($"Average: {avg}");
}

sensor.MeasurementUpdated += OnChangedAvg;

sensor.AddMeasurement(5);
sensor.AddMeasurement(5);

sensor.AddMeasurement(-5);