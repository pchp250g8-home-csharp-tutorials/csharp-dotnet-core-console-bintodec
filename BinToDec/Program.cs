// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

var nDecNum = 0;
var nBinPower = 1;
var nMaxBinaryLen = Math.Truncate(Math.Log2(uint.MaxValue));
var oRegEx = new Regex("^[0-1]+$");
Console.WriteLine("Input a binary number");
var strLine = Console.ReadLine();
var nStrLen = strLine.Length;
var bIsMatch = oRegEx.IsMatch(strLine);
var bRightString = (nStrLen <= nMaxBinaryLen) && (bIsMatch);
if(!bRightString)
{
    Console.WriteLine("Wrong binary number format!!!");
    Console.Read();
    return;
}
for (int i = 0; i < nStrLen; i++)
{
    int nBinDight = strLine[nStrLen - 1 - i] - '0';
    nDecNum += (nBinDight * nBinPower);
    nBinPower *= 2;
}
Console.WriteLine("The decenary equivalent of the binary number {0} is {1}",strLine, nDecNum);
Console.Read();