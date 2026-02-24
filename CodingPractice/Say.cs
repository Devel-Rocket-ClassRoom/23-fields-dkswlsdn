using System;
using System.Collections.Generic;
using System.Text;

public class Say
{
    string message = "안녕하세요.";

    public void Hi()
    {
        message = "반갑습니다.";

        Console.WriteLine(message);
    }
}