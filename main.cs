/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-11-07 00:34:26 
 * @Last Modified by: Pasindu Akalpa 
 * @Last Modified time: 2020-11-07 00:34:26 
 */
using System;
using System.Diagnostics;

class fAssignment
{
    string snArr = null;
    string nArr = null;
    string gArr = null;
    string dobArr = null;

    static void Main(string[] args)
    {
        /*
         * create object from Stopwatch Class
         * Ref:https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?view=netcore-3.1
         */
        Stopwatch s1 = new Stopwatch();
        //create object from fAssignment Class
        fAssignment d1 = new fAssignment();
        //create object from surName Class
        surName f1 = new surName();
        //create object from Name Class
        Name f2 = new Name();
        //create object from doBGendr_FisGen Class
        doBGendr_FisGen f3 = new doBGendr_FisGen();

        //call fillArr Method
        d1.fillArr();
        //call Stopwatch Start function
        s1.Start();
        //call surName_FisGen Method and store value
        string sNcode = f1.surName_FisGen(d1.snArr);
        //call Name_FisGen Method and store value
        string Ncode = f2.Name_FisGen(d1.nArr);
        //call dobgendr_FisGen Method and store value
        string dobngendr = f3.dobgendr_FisGen(d1.dobArr,d1.gArr);

        //call Stopwatch Stop function
        s1.Stop();
        
        //call displayData function 
        d1.displayData(sNcode,Ncode,dobngendr,s1.Elapsed.TotalMilliseconds);
    }

    //Display All the Values
    void displayData(string snme,string nme, string dobgendr, double elapsedT)
    {
        Console.WriteLine("\nFiscal Code is {0}",snme + nme + dobgendr);
        Console.WriteLine("Total Execution Time {0} Milliseconds",elapsedT);
    }

    //Fill Array Method
    (string,string,string,string) fillArr()
    {
        //hardcode first column
        string[,] uID = {{"Name"," "},{"Surname"," "},{"Gender"," "},{"Date of Birth"," "}};
        //fill 2D Array using User Inputs
        for (int i = 0; i < uID.GetLength(0); i++)
        {
            Console.Write("Enter {0}: ",uID[i,0]);
            uID[i,1] = Console.ReadLine().ToUpper();
        }
        //assign array elements to variables
        snArr = uID[1,1];
        nArr = uID[0,1];
        gArr = uID[2,1];
        dobArr = uID[3,1];
        //return variables with value
        return(snArr,nArr,gArr,dobArr);
    }
}