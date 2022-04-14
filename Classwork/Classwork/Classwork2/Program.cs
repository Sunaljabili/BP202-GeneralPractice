using System;

namespace Classwork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting = new Meeting();
            meeting.FromDate = new DateTime(2000, 12, 10);
            meeting.ToDate = new DateTime(2000, 12, 11);
            meeting.Name = "interview-1";


            //Meeting meeting2= new Meeting();
            //meeting2.FromDate = new DateTime(2001, 12, 10);
            //meeting2.ToDate = new DateTime(2001, 12, 11);
            //meeting2.Name = "interview-2";


            //Meeting meeting3 = new Meeting();
            //meeting3.FromDate = new DateTime(2002, 12, 10);
            //meeting3.ToDate = new DateTime(2002, 12, 11);
            //meeting3.Name = "interview-3";

            MeetingSchedule meetingSchedule = new MeetingSchedule();
            
            meetingSchedule.AddMeetings(meeting);
            //meetingSchedule.AddMeetings(meeting2);
            //meetingSchedule.AddMeetings(meeting3);

            //meetingSchedule.ExistMeesting(x=>x.Name==meeting2.Name);
        }

    }
}
