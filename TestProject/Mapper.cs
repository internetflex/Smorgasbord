using System;
using System.Collections.Generic;

namespace TestProject
{
    public class Mapper<TSource,TResult> where TSource : ISource 
                                         where TResult : IResult,new()
    {
        TResult Map(TSource source)
        {
            var nameValues = source.GetNameValues();
            var target = new TResult();
            target.SetNameValues(nameValues);
            return target;
        }
    }
    
public interface ISource
{ 
    Dictionary<string, object> GetNameValues();
}

public interface IResult
{
    void SetNameValues(Dictionary<string, object> nameValues)
}

/*
 * Visitor pattern 

public interface IResult
    {
        IResult Accept(ISource visitor);
    }

    public interface ISource
    {
        IResult Visit(MyTargetA result);
        IResult Visit(MyTargetB result);
    }

    public class MySources : ISource
    {
        public int Content;

        public IResult Visit(MyTargetA result)
        {
            result.ACount = Content;
            return result;
        }
        public IResult Visit(MyTargetB result)
        {
            result.BCount = Content;
            return result;
        }
    }

    public class MyTargetA : IResult
    {
        public int ACount { get; set; }
        public IResult Accept(ISource visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class MyTargetB : IResult
    {
        public int BCount { get; set; }
        public IResult Accept(ISource visitor)
        {
            return visitor.Visit(this); // Use operator overloading based on type parameter. Multiple visit methods in same implemented class
        }
    }
}

*/
