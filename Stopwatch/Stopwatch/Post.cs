using System;
namespace Intermediate_Excercises
{
    public class Post
    {

        public string _title;
        public string _desc;
        private DateTime _date_time;
        private int _noOfVotes;

        public Post()
        {
            this._title = "";
            this._desc = "";
            this._date_time=DateTime.Now;
            this._noOfVotes = 0;
        }
        public string DisplayPost(){
            return " "+this._title + "\n" + this._desc + "\n" + this._noOfVotes;
        }
        public void UpVote(){
            this._noOfVotes = this._noOfVotes + 1;
        }
        public void DownVote()
        {
            this._noOfVotes = this._noOfVotes - 1;
        }
        public int NoOfVotes()
        {
            return _noOfVotes;
        }

        }
       




}
