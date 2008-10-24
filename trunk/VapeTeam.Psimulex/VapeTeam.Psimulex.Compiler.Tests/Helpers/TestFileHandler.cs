using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VapeTeam.Psimulex.Compiler.Tests.Helpers
{
    public static class TestFileHandler
    {
        public static void CreateTestFiles()
        {
            string testFile = @"
import ""src\\in.psi"";
import ""teszt.psi"";

int add(int a, int b)
{
	return a + b;
}

void swap(int & a, int & b)
{
	int tmp = a;
	a = b;
	b = tmp;
}

void wr(string s)
{
	print(s);
}
";

            string testFile1 = @"
void fv(int a)
{
	return;
}
";
            if (File.Exists("src\\in.psi"))
                File.Delete("src\\in.psi");

            if (File.Exists("src\\in1.psi"))
                File.Delete("src\\in1.psi");

            if(!Directory.Exists("src"))
                Directory.CreateDirectory("src");

            StreamWriter sw = new StreamWriter("src\\in.psi");
            sw.Write(testFile);
            sw.Close();

            StreamWriter sw1 = new StreamWriter("src\\in1.psi");
            sw1.Write(testFile1);
            sw1.Close();
        }

        public static void DeleteTestFiles()
        {
            if (File.Exists("src\\in.psi"))
                File.Delete("src\\in.psi");

            if (File.Exists("src\\in1.psi"))
                File.Delete("src\\in1.psi");

            if (Directory.Exists("src"))
                Directory.Delete("src");
        }
    }
}
