using System;
using System.Collections.Generic;
using System.Text;
using first_exam.DTO;
using first_exam.DAO;

namespace first_exam.Logic
{
    public class CreateCountryListOne
    {
        public Dto_CountryListNode createCountryListOne()
        {
            List<int> Code = new List<int>()
            {
                1, 2, 3, 4, 5, 6
            };

            List<string> CountryName = new List<string>()
            {
                "Estados Unidos", "Rusia", "China", "Alemania", "Reino Unido", "Francia"
            };

            List<int> NumberHospitals = new List<int>()
            {
                1200, 500, 900, 1500, 475, 1010
            };

            List<string> ProvenanceList = new List<string>()
            {
                "List One", "List One", "List One", "List One", "List One", "List One"
            };

            Dao_CountryList obj_dao_Country = new Dao_CountryList();
            Dto_CountryListNode countryListNode = obj_dao_Country.createCountryList(Code, CountryName, NumberHospitals, ProvenanceList);
            return countryListNode;
        }
    }
}
