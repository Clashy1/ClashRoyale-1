using System;

namespace ClashRoyale.Utilities.Utils
{
    public class TimeUtils
    {
        public static int GetSecondsUntilNextMonth
        {
            get
            {
                var now = DateTime.UtcNow;

                if (now.Month != 12)
                    return (int) (new DateTime(now.Year, now.Month + 1, 1, now.Hour,
                                      now.Minute, now.Second) - now).TotalSeconds;

                return (int) (new DateTime(now.Year + 1, 1, 1, now.Hour,
                                  now.Minute, now.Second) - now).TotalSeconds;
            }
        }

        public static int GetSecondsUntilTomorrow
        {
            get
            {
                var now = DateTime.UtcNow;
                var tomorrow = now.AddDays(1).Date;

                return (int) (tomorrow - now).TotalSeconds;
            }
        }
        public static int LeaderboardTimer
        {
            get
            {
                DateTime moment = DateTime.Now;
                int day = moment.Day * 86400 + moment.Hour * 3600 + moment.Minute * 60 + moment.Second;
                var seconds = (int)2595000;
                return (int)(seconds - day);
            }
        }
        public static int CurrentUnixTimestamp => (int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }
}
