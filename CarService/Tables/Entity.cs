using System;
using System.Data;


namespace CarService.Tables
{
    public abstract class Entity
    {
        public Int32 Id { get; protected set; }
        public abstract bool Initialize(DataRow row);


    }
}
