using System.Text.RegularExpressions;

public class Name
{
    public string Name_FisGen(string a)//Name Code Generator Method
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
}