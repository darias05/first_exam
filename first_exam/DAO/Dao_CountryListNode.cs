using System;
using System.Collections.Generic;
using System.Text;
using first_exam.DTO;

namespace first_exam.DAO
{
    public class Dao_CountryListNode
    {
        public Dto_CountryListNode countryListNode;
        public Dto_CountryListNode Head;

        public Dto_CountryListNode createCountryListNode(List<Dto_CountryList> Country)
        {
            for (int i = 0; i < Country.Count; i++)
            {
                countryListNode = AddCountry(Country[i]);
            }

            return countryListNode;
        }

        public Dto_CountryListNode AddCountry(Dto_CountryList countryList)
        {
            Dto_CountryListNode countryListNode = new Dto_CountryListNode();
            countryListNode.countryList = countryList;

            if (Head == null)
            {
                Head = countryListNode;
            }
            else
            {
                Dto_CountryListNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = countryListNode;
            }

            return Head;
        }
    }
}
