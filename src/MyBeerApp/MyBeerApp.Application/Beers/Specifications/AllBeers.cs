using LinqBuilder;
using MyBeerApp.Domain.Beers;
using System;
using System.Linq.Expressions;

namespace MyBeerApp.Application.Beers.Specifications
{
    public class AllBeers : Specification<Beer>
    {
        public override Expression<Func<Beer, bool>> AsExpression() =>
            beer => true;
    }
}