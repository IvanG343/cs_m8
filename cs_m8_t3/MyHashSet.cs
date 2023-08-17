using System;
using System.Collections.Generic;

namespace cs_m8_t3 {
    public class MyHashSet {
        private HashSet<int> hs = new HashSet<int>();

        public bool AddToHashSet(int a) {
            bool result;
            if (!isNumberExist(a)) {
                hs.Add(a);
                result = true;
            } else {
                result = false;
            }
            return result;
        }

        public bool isNumberExist(int a) {
            bool result;
            if (hs.Contains(a)) {
                result = true;
            } else {
                result = false;
            }
            return result;
        }

    }
}