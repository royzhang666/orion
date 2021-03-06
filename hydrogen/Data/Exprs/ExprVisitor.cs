﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs
{
    public class ExprVisitor
    {
        public virtual void VisitGt<T>(Gt<T> node)
        {
            
        }

        public virtual void VisitGtOrEq<T>(GtOrEq<T> node) 
        {

        }
        public virtual void VisitLt<T>(Lt<T> node)
        {

        }

        public virtual void VisitLtOrEq<T>(LtOrEq<T> node)
        {

        }
        public virtual void VisitEq<T>(Eq<T> node)
        {

        }
        public virtual void VisitJoin<T>(Join<T> node)
        {

        }
        public virtual void VisitConstant(Constant node)
        {

        }
        public virtual void VisitFilter(Filter node)
        {

        }
        public virtual void VisitAnd(And node)
        {
            var (l, r) = node;
            l.Accept(this);
            r.Accept(this);
        }
        public virtual void VisitOr(Or node)
        {
            var (l, r) = node;
            l.Accept(this);
            r.Accept(this);
        }
        public virtual void VisitInsert(Insert node)
        {

        }
    }
}
