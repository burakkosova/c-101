using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public enum Type
    {
        TODO = 1, INPROGRESS=2, DONE=3
    }
    
    public enum Size
    {
        XS = 1, S=2, M=3, L=4, XL=5
    }
    public class Card
    {
        public Type type;
        public String Title;
        public String Content;
        public int MemberId;
        public Size size;
    }
}
