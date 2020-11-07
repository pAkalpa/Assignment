/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-11-07 00:34:26 
 * @Last Modified by: Pasindu Akalpa 
 * @Last Modified time: 2020-11-07 00:34:26 
 */
using System;

public class doBGendr_FisGen
{
    //Date of Birth & Gender Fiscal Code Generator Method
    public string dobgendr_FisGen(string a,string b)
    {
        string ans = null;
        string year = null;
        string mCode = null;
        string dob = null;
        int fDob = 0;

        string[] dateD = a.Split('/');
        string dateN = string.Concat(dateD[1]+'/'+dateD[0]+'/'+dateD[2]);
        int dayOb = int.Parse(dateD[0]);
        /*
         * This tstruct is used for Validate Date
         * Ref:https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=netcore-3.1
         */
        DateTime dateValue;
        //Validate Date
		if(DateTime.TryParse(dateN, out dateValue))
		{
			year = dateD[2].Remove(0,2);
            switch (dateD[1])
            {
                case "1":
                    mCode = "A";
                break;
                case "2":
                    mCode = "B";
                break;
                case "3":
                    mCode = "C";
                break;
                case "4":
                    mCode = "D";
                break;
                case "5":
                    mCode = "E";
                break;
                case "6":
                    mCode = "H";
                break;
                case "7":
                    mCode = "L";
                break;
                case "8":
                    mCode = "M";
                break;
                case "9":
                    mCode = "P";
                break;
                case "10":
                    mCode = "R";
                break;
                case "11":
                    mCode = "S";
                break;
                case "12":
                    mCode = "T";
                break;
            }
            //Gender Validate
            if (b == "M" || b == "F")
            {
                if (b == "M")
                {
                    if (dayOb < 10)
                    {
                        dob = "0"+dateD[0];
                    }
                    else
                    {
                        dob = dateD[0];
                    }
                }

                if (b == "F")
                {
                    fDob = dayOb + 40;
                    dob = fDob.ToString();
                }
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
		}
		else
		{
			Console.WriteLine("Invalid Date");
		}
        ans = string.Concat(year + mCode + dob);
        return ans;
    }
}