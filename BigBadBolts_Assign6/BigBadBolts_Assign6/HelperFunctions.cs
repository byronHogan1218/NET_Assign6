using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
namespace BigBadBolts_Assign6
{
    public class HelperFunctions
    {

            /**
            * This function gets and reads input from file provided to us. 
            */
        public static void ReadInput()
        {
            string currentLine;
            string[] tokens;

            //This will read the post file and build the objects from there
            using (StreamReader inFile = new StreamReader("..//..//data.txt"))
            {
                currentLine = inFile.ReadLine(); //prime the read
                while (currentLine != null)
                {
                    tokens = currentLine.Split('\t');
                    People personToAdd = new People(//build the person to add
                        tokens[0],//name
                        tokens[1]//number
                        );

                    MainForm.myPeople.Add(personToAdd);
                 
                    currentLine = inFile.ReadLine(); //get the next line
                }
            }

            }
        
    }
}
