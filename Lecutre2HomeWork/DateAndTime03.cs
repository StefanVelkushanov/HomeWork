using System;
using System.Collections.Generic;
using System.Text;
using Lecture2HomeWork;

namespace Lecture2HomeWork
{
    public class DateAndTime03
    {
        public static void TimeAndDate03()
        {
            DateTime CurrentTime = DateTime.Now;
            Console.WriteLine($"\n Year = {CurrentTime.Year} \n Month = {CurrentTime.Month} \n Day = {CurrentTime.Day} \n Hour = {CurrentTime.Hour} \n Minute = {CurrentTime.Minute} \n Second = {CurrentTime.Second} \n Milisecond = {CurrentTime.Millisecond}");
        }
    }
}