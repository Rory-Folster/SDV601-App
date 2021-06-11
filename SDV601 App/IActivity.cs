using System;

namespace SDV601_App
{
    public interface IActivity
    {
        DateTime CreatedDate { get; set; }
        string Name { get; set; }
        decimal Value { get; set; }
    }
}