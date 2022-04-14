using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork2
{
   public class MeetingSchedule
    {
       public  List<Meeting> meetings = new List<Meeting>();

        public void AddMeetings(Meeting meeting)
        {
            if (meetings.Exists(m => m.FromDate > meeting.ToDate || m.ToDate < meeting.FromDate))
            {
                meetings.Add(meeting);
            }
            else
            {
                throw new Exception("Vaxtiniz dushmur");
            }
        }

        public int FindMeetingsCount(DateTime time)
        {
            int count = 0;
            foreach (var item in meetings)
            {
                if (item.FromDate>time)
                {
                    count++;
                }
            }
            return count;
        }

        public bool ExistMeestingByName(string name)
        {
            foreach (var item in meetings)
            {
                if (item.Name==name)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Meeting> FindMeetings(Predicate<Meeting> predicate) {

            return meetings.FindAll(predicate);
        }

        public bool ExistMeesting(Predicate<Meeting> predicate)
        {

            return meetings.Exists(predicate);
        }
    }
}
