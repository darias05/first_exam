using System;
using System.Collections.Generic;
using System.Text;
using first_exam.DTO;
using first_exam.DAO;

namespace first_exam.Logic
{
    public class CreateCountryListTwo
    {
        public Dto_CountryListNode createCountryListTwo()
        {
            List<int> Code = new List<int>()
            {
                1, 2, 3, 4
            };

            List<string> CountryName = new List<string>()
            {
                "Japón", "Israel", "Arabia Saudita", "Corea del Sur"
            };

            List<int> NumberHospitals = new List<int>()
            {
                1000, 800, 400, 1400
            };

            List<string> ProvenanceList = new List<string>()
            {
                "List Two", "List Two", "List Two", "List Two"
            };

            Dao_CountryList obj_dao_Country = new Dao_CountryList();
            Dto_CountryListNode countryListNode = obj_dao_Country.createCountryList(Code, CountryName, NumberHospitals, ProvenanceList);
            return countryListNode;
        }
    }
}
