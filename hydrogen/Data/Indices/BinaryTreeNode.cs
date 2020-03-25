﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Indices
{
    public struct BinaryTreeNode<T>
    {
        public int l;
        public int r;
        public int h;
        public int p;
        public int n;
        public T val;
    }
}
