using System;

namespace Learn
{
    public static class InitOnlySetter
    {
        public static void DoWork()
        {
            var d = new DbMetadata()
            {
                DbName = "sad",
                DbType = "wq"
            };

            //d.DbType = "error: DbType is not settable
            //init-only property can only be assigned in an object initializer, or on \"this\" sau \"base\" in instance constructor or on \"init\" accessor";
            
            d.DbName = "2321";
        }
    }

    public class DbMetadata
    {
        public string DbName { get; set; }
        public string DbType { get; init; }
    }
}
