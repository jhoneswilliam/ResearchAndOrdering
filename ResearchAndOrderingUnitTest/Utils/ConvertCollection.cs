using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndOrderingUnitTest.Utils
{
    public class ConvertCollection<T>
    {
        public static string ToString(LinkedList<T> linkedList)
        {
            string result = "";
            if (linkedList != null)
            {
                while (linkedList.Count > 0)
                {
                    result += string.Format(" -> [{0}]", linkedList.First());
                    linkedList.RemoveFirst();
                }
            }
            else
            {
                result = "null";
            }
            return result;
        }        
    }
}
