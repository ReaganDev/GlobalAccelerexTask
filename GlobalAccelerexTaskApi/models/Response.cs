namespace GlobalAccelerexTaskApi.models
{
    public class Response : BaseResponse
    {
        public Response(KeyValuePair<string, List<RequestType>> data) : base(data)
        {

            if (data.Value.Count > 0)
                this.UnixTimeToDateTime(data.Value, data.Key);
            else
                OpeningHours.Add("closed");

        }
    }
}
