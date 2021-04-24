using System;
using System.Collections.Generic;
using System.Text;
using first_exam.DTO;

namespace first_exam.DAO
{
    public class Dao_CountryList
    {
        public Dto_CountryListNode createCountryList(List<int> Code, List<string> CountryName, List<int> NumberHospitals, List<string> ProvenanceList)
        {
            List<Dto_CountryList> country = new List<Dto_CountryList>();

            for (int i = 0; i < CountryName.Count; i++)
            {
                country.Add(new Dto_CountryList()
                {
                    code = Code[i],
                    country_name = CountryName[i],
                    number_of_hospitals = NumberHospitals[i],
                    provenance_list = ProvenanceList[i],
                });
            }

            Dao_CountryListNode dao_CountryListNode = new Dao_CountryListNode();
            Dto_CountryListNode countryListNode = dao_CountryListNode.createCountryListNode(country);
            return countryListNode;
        }
    }
}
