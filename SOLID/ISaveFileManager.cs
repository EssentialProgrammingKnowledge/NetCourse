namespace SOLID
{
    internal interface ISaveFileManager : ISaveJsonFile, ISaveXmlFile
    {
        /* //Wersja bez uwzglednienia zasady I
         * public byte[] SaveAsJson(object obj);
         * public byte[] SaveAsXml(object obj);
         */
        
    }

    internal interface ISaveJsonFile
    {
        public byte[] SaveAsJson(object obj);
    }
    internal interface ISaveXmlFile
    {
        public byte[] SaveAsXml(object obj);
    }
}
