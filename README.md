# phungminhanh.github.io class listcode
    {
      static public List<string> Code =new List<string>();
        static public  string RandomString()
        {
            String  result ="";
             while (true)
            {   StringBuilder sb = new StringBuilder();
                char c;
                Random rand = new Random();
                int h;
                for (int i = 0; i < 7; i++)
                {
                    h = Convert.ToInt32(rand.Next(49, 57));
                    if (h % 2 == 0)
                    {
                        c = Convert.ToChar(Convert.ToInt32(rand.Next(66, 90)));
                    }
                    else
                        c = Convert.ToChar(Convert.ToInt32(rand.Next(49, 57)));
                    sb.Append(c);
 }

                if (!Code.Contains(sb.ToString()) && sb.ToString().Length == 7)
                {

                    Code.Add(sb.ToString());
                    result = sb.ToString();
                    break;
                }

            }
            return result;


        }
    }
}
