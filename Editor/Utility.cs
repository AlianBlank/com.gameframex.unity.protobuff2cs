namespace Proto2CS.Editor
{
    internal static class Utility
    {
        public static readonly char[] splitChars = { ' ', '\t' };

        public static readonly string[] splitNotesChars = { "//" };

        public static string ConvertType(string type)
        {
            string typeCs = "";
            switch (type)
            {
                case "int16":
                    typeCs = "short";
                    break;
                case "uint16":
                    typeCs = "ushort";
                    break;
                case "int32":
                case "sint32":
                case "sfixed32":
                    typeCs = "int";
                    break;
                case "uint32":
                case "fixed32":
                    typeCs = "uint";
                    break;
                case "int64":
                case "sint64":
                case "sfixed64":
                    typeCs = "long";
                    break;
                case "uint64":
                case "fixed64":
                    typeCs = "ulong";
                    break;
                case "bytes":
                    typeCs = "byte[]";
                    break;
                case "map<int32,int64>":
                    typeCs = "Dictionary<int, long>";
                    break;
                case "string":
                    typeCs = "string";
                    break;
                case "bool":
                    typeCs = "bool";
                    break;
                case "double":
                    typeCs = "double";
                    break;
                case "float":
                    typeCs = "float";
                    break;
                default:
                    typeCs = type;
                    break;
            }

            return typeCs;
        }
    }
}