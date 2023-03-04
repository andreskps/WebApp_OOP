using System;


namespace Web_OOP
{
    internal class Date
    {
        #region Feels
        private int _day;
        private int _month;
        private int _year;
        #endregion

        #region Methods
        public Date(int day, int month, int year)//constructor
        {
            _day = CheckDay(day,month,year);
            _month = CheckMonth(month);
            _year = CheckYear(year);
            
        }

        private int CheckYear(int year)
        {
            if(year >= 1900)
            {
                return year;
            }

            throw new YearExeption("The year is invalid");
        }

        private int CheckDay(int day,int month , int year)
        {
            if(month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPorMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if(day >= 1 && day <= daysPorMonth[month])
            {
                return day;
            }

            throw new DayException("The day is invalid");


        }

        private bool IsLeapYear(int year) 
        { 
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }
        private int CheckMonth (int month) {

          
                if (month >= 1 && month <= 12)
                {
                    return month;
                }
           
                throw new MonthException("The month is invalid");
    
        }

        public override string ToString()
        {
            return $"{_day}/{_month}/{_year}";
        }
        #endregion
    }
}
