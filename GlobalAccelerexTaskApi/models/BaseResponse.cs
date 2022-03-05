namespace GlobalAccelerexTaskApi.models
{
    public abstract class BaseResponse
    {
        public BaseResponse(KeyValuePair<string, List<RequestType>> data)
        {
            Day = data.Key;

        }

        public string Day { get; set; }

        public List<string> OpeningHours { get; set; } = new List<string>();
        private void ExtractOpeningHourTimeInHumanUnderstandableFormat(RequestType workingHours, string type)
        {
            var datTime = new DateTime(1970, 01, 01, 0, 0, 0, System.DateTimeKind.Utc);
            datTime = datTime.AddSeconds(workingHours.value);
            OpeningHours.Add($"{type} : {datTime.ToShortTimeString()}");
        }

        public void UnixTimeToDateTime(List<RequestType> workingHours, string day)
        {
            foreach (var time in workingHours)
            {

                if (time.type.ToLower().Equals("open"))
                {
                    ExtractOpeningHourTimeInHumanUnderstandableFormat(time, "open");

                }

                if (time.type.ToLower().Equals("close"))
                {
                    ExtractOpeningHourTimeInHumanUnderstandableFormat(time, "close");


                }

            }

        }
    }
}
