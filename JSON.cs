namespace jsonHandler
{
    public class JSON
    {
        private string startPath = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        public string Stringify(string raw)
        {
            /*
             * changes the raw data that looks like this:
             * {
             *     key: value
             *  }
             *  
             *  to this:
             *  "{key:value}"
             */
            raw = raw.Replace("\n", "");
            raw = raw.Replace("\t", "");
            raw = raw.Replace("\r", "");
            raw = raw.Replace(" ", "");
            return raw;
        }
        public void sendData(string path, string data)
        {
            /*
             * sends data to a file
             */
            File.WriteAllText(startPath + path, data);
        }
        public string getJSON(string path)
        {
            /*
             * gets the json data from a file
             */
            return Stringify(File.ReadAllText(startPath + path));
        }
        public string GetValue(string json, string key)
        {
            /*
             * gets the value of a key in a json string
             */
            string[] split = json.Split(',');
            foreach (string s in split)
            {
                if (s.Contains(key))
                {
                    string[] split2 = s.Split(':');
                    return split2[1];
                }
            }
            return "null";
        }
        public string ChangeValue(string json, string key, string value)
        {
            /*
             * changes the value of a key in a json string
             * if none is found, it will add it to the json string as a new key and value
             */
            string temp = json;
            temp = temp[1..(temp.Length - 1)];
            string[] split = temp.Split(',');

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Contains(key))
                {
                    string[] split2 = split[i].Split(':');
                    split2[1] = value;
                    split[i] = $"{split2[0]}:\"{split2[1]}\"";
                    temp = $"{{{string.Join(",", split)}}}";
                    return temp;
                }
            }
            return $"{{{temp},\"{key}\":\"{value}\"}}";
        }

    }
}
