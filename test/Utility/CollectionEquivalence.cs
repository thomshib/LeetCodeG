using System;
using Xunit;
using source;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace test.utility
{
    public class CollectionEquivalence{

        public static bool AreEqual<T>(IList<T> list1, IList<T> list2){
            if(list1?.Count != list2?.Count){
                return false;
            }

            return list1.SequenceEqual(list2);
        }

        public static bool AreEqual<T>(IList<List<T>> list1, IList<List<T>> list2){
            return list1.All(innerList1 => list2.Any(innerList2 => AreEqual(innerList1,innerList2)));

        }

        public static bool AreEqual<T>(IList<IList<T>> list1, IList<IList<T>> list2){
            return list1.All(innerList1 => list2.Any(innerList2 => AreEqual(innerList1,innerList2)));
            
        }
    }
}