using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw2
{

// Для класса Date из предыдущего задания предусмотреть в
// свойствах и методах проверку допустимости передаваемых
// значений. В случае недопустимых значений необходимо
// генерировать исключения.
    public class Date
    {
        private int day;
private int month;
private int year;

string DayOFWeek;

    public int Day{
        get{
            return day;
        }
     

        
        set{
            try{
            if(value > 0 && value <= 31){
                day = value;
            }
            else{
                throw new Exception("неверное значение. incorrect value");
            }
        }
         catch(Exception ex){
            Write("ошибка: " + ex.Message);
             return;
         }
        }
       
    }


     public string Day_Of_Week{
        get{
            return DayOFWeek;
        }
        set{
            try{

    
            if(value != null){
                DayOFWeek = value;
            }
            else{
                 throw new Exception("неверное значение. incorrect value");
            }
            }
            catch(Exception ex){
                Write("ошибка: " + ex.Message);
                 return;
            }
        }
    }



    public int Month{
        get{
            return month;
        }

        set{
            try{

        
            if(value > 0 && value <= 12){
                month = value;
            }
            else{
                  throw new Exception("неверное значение. incorrect value");
            }
                }
                catch(Exception ex){
                Write("ошибка: " + ex.Message);
                 return;
                }
        }
    }


    public int Year{
        get{
            return year;
        }

        set { 
            try{

            
            if(value > 0){
            year = value;
            }
            else{
            throw new Exception("неверное значение. incorrect value");
            }
            }
            catch(Exception ex){
                 Write("ошибка: " + ex.Message);
                 return;
            }
             }
    }

public Date() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) {}
public Date(int day, int month, int year){
Year = year;
Month = month;
Day = day;
}



 public void DateDiff(){
         // Ввод даты от пользователя
    WriteLine("Enter a day: ");
    int day1 = int.Parse(Console.ReadLine());

    WriteLine("Enter a month: ");
    int month1 = int.Parse(Console.ReadLine());

    WriteLine("Enter a year: ");
    int year1 = int.Parse(Console.ReadLine());

    // Ввод второй даты
    WriteLine("Enter the second date:");
    WriteLine("Enter a day: ");
    int day2 = int.Parse(Console.ReadLine());

    WriteLine("Enter a month: ");
    int month2 = int.Parse(Console.ReadLine());

    WriteLine("Enter a year: ");
    int year2 = int.Parse(Console.ReadLine());

    // Создаем объекты DateTime
    DateTime firstDate = new DateTime(year1, month1, day1);
    DateTime secondDate = new DateTime(year2, month2, day2);

    // Вычисляем разницу в днях
    TimeSpan difference = secondDate - firstDate;
    int result = Math.Abs(difference.Days); // Абсолютное значение разницы в днях

    // Вывод результата
    WriteLine($"Difference in days: {result}");
        
    }



public void changeDate(){
    WriteLine("enter a value of days");
    string answer = Console.ReadLine();
    int days = int.Parse(answer);

this.Day += days;
int past = days;

for(int i = 0; i > past; i++){
    past--;

    if(this.Day > 31){
        this.Day = 1;
        this.Month += 1;

        if(this.Month > 12){
            this.Month = 1;
        }
    }
}
    
    Write("new date: " + this.Day + "." + this.Month + "." + this.Year + "\n");

}


public void print(){
Write("date: " + this.Day + "." + this.Month + "." + this.Year + "\n");
}


    }
}