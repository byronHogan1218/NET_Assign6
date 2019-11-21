using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
///*******************************************************************
//*                                                                  *
//*  CSCI 473-1/504-1       Assignment 6                Fall   2019  *
//*                                                                  *
//*                                                                  *
//*  Program Name:  Reddit                                           *
//*                                                                  *
//*  Programmer:    Byron Hogan,  z1825194                           *
//*                 Margaret Higginbotham, z1793581                  *
//*                                                                  *
//*******************************************************************/
/**
 * Pupose : This provides a definition of the People class
 */
namespace BigBadBolts_Assign6
{
    public class People
    {
        private string name;
        private string number;

        public People(string _name,string _number)
        {
            name = _name;
            number = _number;
        }

        public string Name
        {
            get { return name; }
        }
        public string Number
        {
            get { return number; }
        }
    }//end people class


    /** Collection of People objects. This class
  * implements IEnumerable so that it can be used
  * with ForEach syntax. 
  */
    public class Peoples : IEnumerable
    {
        private People[] _people;
        public Peoples(People[] pArray)
        {
            _people = new People[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class PeopleEnum : IEnumerator
    {
        public People[] _people;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public PeopleEnum(People[] list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public People Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }


}
