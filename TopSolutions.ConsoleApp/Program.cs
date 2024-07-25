using TopSolutions.ConsoleApp.Samples.QuickTest;

//DateTime.MinValue.ToString(new CultureInfo("en-US"));

var dateStr = DateTime.Today.AddDays(20);//"2023-22-24";

//var dateStr2 = StaticClassTest.GetDateStringValue(dateStr);
//Console.WriteLine(dateStr2);

var strDate = "11/12/2023 12:00:00 AM";
var convertToDateTime0AM = StaticClassTest.ConvertToDateTime0AM(StaticClassTest.GetDateTimeValue(strDate));

var getDateTimeValue = StaticClassTest.GetDateTimeValue(strDate);
var getDateTimeValueWithExact = StaticClassTest.GetDateTimeValueWithExact(strDate, "MM/dd/yyyy", true);

var date3 = StaticClassTest.GetStringValue(strDate);
Console.WriteLine(date3);