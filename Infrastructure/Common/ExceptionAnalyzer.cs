namespace Pro.APIConsume.Infrastructure.Common
{
    public static class ExceptionAnalyzer
    {
        public static void CheckResponse(string response)
        {
            if (response == string.Empty || response == null)
            {
                throw new HSLParkAndRideAPIException($"Error in method: GetHSLParkAndRideService, cannot get response from HSL Park and Ride service API.");
            }
        }
    }
}
