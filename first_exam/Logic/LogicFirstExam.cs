using System;
using System.Collections.Generic;
using System.Text;
using first_exam.DTO;

namespace first_exam.Logic
{
    public class LogicFirstExam
    {
        public Dto_CountryListNode junctionOfNodes(Dto_CountryListNode countryListNodeOne, Dto_CountryListNode countryListNodeTwo)
        {
            Dto_CountryListNode Head = countryListNodeTwo;
            int countCountryList = 1;

            countryListNodeTwo = countryListNodeOne;

            Dto_CountryListNode last = countryListNodeTwo;
            while (last.Next != null)
            {
                last = last.Next;
            }
            last.Next = Head;

            Dto_CountryListNode count = countryListNodeTwo;
            while (count.Next != null)
            {
                countCountryList++;
                count = count.Next;
            }

            Dto_CountryListNode last_print = countryListNodeTwo;
            for (int i = 0; i < countCountryList; i++)
            {
                Console.WriteLine("Code: " + last_print.countryList.code);
                Console.WriteLine("Country Name: " + last_print.countryList.country_name);
                Console.WriteLine("Number Of Hospitals: " + last_print.countryList.number_of_hospitals);
                Console.WriteLine("Provenance List: " + last_print.countryList.provenance_list);
                Console.WriteLine("\n");
                last_print = last_print.Next;
            }

            //Dto_CountryListNode last_print = countryListNodeTwo;
            //while (last_print.Next != null)
            //{
            //    Console.WriteLine("Code: " + last_print.countryList.code);
            //    Console.WriteLine("Country Name: " + last_print.countryList.country_name);
            //    Console.WriteLine("Number Of Hospitals: " + last_print.countryList.number_of_hospitals);
            //    Console.WriteLine("Provenance List: " + last_print.countryList.provenance_list);
            //    Console.WriteLine("\n");
            //    last_print = last_print.Next;
            //}

            //Console.WriteLine("Code: " + last_print.countryList.code);
            //Console.WriteLine("Country Name: " + last_print.countryList.country_name);
            //Console.WriteLine("Number Of Hospitals: " + last_print.countryList.number_of_hospitals);
            //Console.WriteLine("Provenance List: " + last_print.countryList.provenance_list);

            return countryListNodeTwo;
        }
    }
}
