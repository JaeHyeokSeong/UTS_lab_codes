namespace week10_lab_codes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // [1] Input
            const string FILENAME = "files.txt";
            int txt = 0, pdf = 0, xml = 0;

            // [2] Process
            using (StreamReader sr = new StreamReader(FILENAME))
            {
                try
                {
                    string? line = sr.ReadLine();
                    if (!String.IsNullOrEmpty(line))
                    {
                        line = line.Replace('{'.ToString(), string.Empty);
                        line = line.Replace('}'.ToString(), string.Empty);
                        string[] contents = line.Split(',');
                        txt = contents.Where(c => c.Contains(".txt") || c.Contains(".TXT")).Count();
                        pdf = contents.Where(c => c.Contains(".pdf") || c.Contains(".PDF")).Count();
                        xml = contents.Where(c => c.Contains(".xml") || c.Contains(".XML")).Count();
                    }

                } catch(Exception e)
                {
                    Console.WriteLine("[Warning] Error happened while reading {0} text file" +
                        "in Program class", FILENAME);
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.HelpLink);
                }
            }

            // [3] Output
            Console.WriteLine("{0} File(s) with txt Extension", txt);
            Console.WriteLine("{0} File(s) with pdf Extension", pdf);
            Console.WriteLine("{0} File(s) with xml Extension", xml);
        }
    }
}