using System;
using System.Collections.Generic;
using first_exam.DTO;
using first_exam.DAO;
using first_exam.Logic;

namespace first_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de Nodos de CountryListOne
            CreateCountryListOne createCountryListOne = new CreateCountryListOne();
            Dto_CountryListNode countryListNodeOne = createCountryListOne.createCountryListOne();

            //Creación de Nodos de CountryListTwo
            CreateCountryListTwo createCountryListTwo = new CreateCountryListTwo();
            Dto_CountryListNode countryListNodeTwo = createCountryListTwo.createCountryListTwo();

            //Unir nodo 1 antes del nodo 2
            LogicFirstExam logicFirstExam = new LogicFirstExam();
            Dto_CountryListNode countryListJoinedNode = logicFirstExam.junctionOfNodes(countryListNodeOne, countryListNodeTwo);
        }
    }
}
