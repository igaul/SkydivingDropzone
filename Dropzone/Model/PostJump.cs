using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dropzone.Model
{
    public class PostJump
    {
        const int MAX_LEN = 200;


        [PrimaryKey, AutoIncrement]
        public int JumpNumber { get; set; }  // todo display in AddJumpPage ???
        [MaxLength(MAX_LEN)]
        public string Date { get; set; }
        [MaxLength(MAX_LEN)]
        public string Place { get; set; }
        [MaxLength(MAX_LEN)]
        public string Aircraft { get; set; }
        [MaxLength(MAX_LEN)]
        public string Equipment { get; set; }
        [MaxLength(MAX_LEN)]
        public string FreeFallTime { get; set; }
        [MaxLength(MAX_LEN)]
        public string FlyingType { get; set; }
        
 
        // pretty print display line todo
        public string getDisplay()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(JumpNumber + ": ");
            sb.Append(Date + " ");
            sb.Append(Place);

            return sb.ToString();
        }
     
    }
}
