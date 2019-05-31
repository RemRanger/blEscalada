namespace blEscalada
{
    public enum ApiKind { read, write };

    public class Utils
    {
        const string rootUrl = "https://www.remranger.com/escalada-api";
        public static string GetApiUrl(string apiName, ApiKind kind)
        {
            return $"{rootUrl}/{apiName}-{kind}.php";
        }
        public static string GetResultPic(int? result)
        {
            switch (result)
            {
                case 0: return "images/result-fail.png";
                case 1: return "images/result-faults.png";
                case 2: return "images/result-success.png";
                default: return null;
            }
        }
    }
}
