/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-11-06 19:39:46 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-11-07 00:46:57
 */
using System;
using System.Text.RegularExpressions;

class fAssignment
{
    static void Main(string[] args)
    {
        string sname = Console.ReadLine().ToUpper();
        string name = Console.ReadLine().ToUpper();
        string doB = Console.ReadLine();
        string gendr = Console.ReadLine().ToUpper();

        fAssignment f1 = new fAssignment();//create Object

        string snme = f1.surName_FisGen(sname);//call surName_FisGen Method
        string nme = f1.Name_FisGen(name);//call Name_FisGen Method
        string dob = f1.doBGendr_FisGen(doB,gendr);

        Console.WriteLine(snme + nme + dob);
    }

    string surName_FisGen (string a)//Surname Code Generator Method 
    {
        string ans = null;
        string nWv = null;
        string voW = null;
        nWv = Regex.Replace(a,"[AEIOU]", "");

        if (a.Length > 0)
        {
            if (a.Length < 3)
            {
                ans = a +"X";
            }
            else if (nWv.Length < 3)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    bool? x = null;
                    switch (a[j])
                    {
                        case 'A':
                            voW = "A";
                            x = true;
                        break;
                        case 'E':
                            voW = "E";
                            x = true;
                        break;
                        case 'I':
                            voW = "I";
                            x = true;
                        break;
                        case 'O':
                            voW = "O";
                            x = true;
                        break;
                        case 'U':
                            voW = "U";
                            x = true;
                        break;
                    }
                    if (x == true)
                    {
                        break;
                    }
                    else
                    {
                        x = false;
                    }
                }
                ans = nWv + voW;
            }
            else if (a.Length > 3)
            {
                ans = nWv;
            }
        }
        return ans.Substring(0,3);
    }

    string Name_FisGen(string a)//Name Code Generator Method
    {
        string ans = null;
        string nWv = null;
        string voW = null;
        nWv = Regex.Replace(a,"[AEIOU]", "");
        if (nWv.Length == 3)
        {
            ans = nWv; 
        }
        else if (nWv.Length > 3)
        {
            ans = string.Concat(nWv[0],nWv[2],nWv[3]);
        }
        else if (a.Length < 3)
        {
            ans = a +"X";
        }
        else if (nWv.Length < 3)
        {
            for (int j = 0; j < a.Length; j++)
            {
                bool? x = null;
                switch (a[j])
                {
                    case 'A':
                        voW = "A";
                        x = true;
                    break;
                    case 'E':
                        voW = "E";
                        x = true;
                    break;
                    case 'I':
                        voW = "I";
                        x = true;
                    break;
                    case 'O':
                        voW = "O";
                        x = true;
                    break;
                    case 'U':
                        voW = "U";
                        x = true;
                    break;
                }
                if (x == true)
                {
                    break;
                }
                else
                {
                    x = false;
                }
            }
            ans = nWv + voW;
        }
        return ans.Substring(0,3);
    }

    string doBGendr_FisGen(string a,string b)//Date of Birth & Gender Code Generator Method
    {
        string ans = null;
        string year = null;
        string mCode = null;
        string dob = null;
        int fDob = 0;

        string[] dateD = a.Split('/');
        string dateN = string.Concat(dateD[1]+'/'+dateD[0]+'/'+dateD[2]);
        int dayOb = int.Parse(dateD[0]);
        DateTime dateValue;
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
            if (b == "M" || b == "F")
            {
                if (b == "M")
                {
                    if (dayOb < 10)
                    {
                        dob = "0"+dateD[0];
                    }
                }
                else
                {
                    dob = dateD[0];
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