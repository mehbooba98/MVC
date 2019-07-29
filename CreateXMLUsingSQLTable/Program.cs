using System;
using System.Data;
using System.Data.SqlClient;




namespace CreateXMLUsingSQLTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Connection string
            SqlConnection cnAW = new SqlConnection("Data Source=LAPTOP-E1J6KUU3\\TECHBROTHERSSQL; user id=XMLUser; password=Pa$$w0rd2020; Initial Catalog=AdventureWorks2014;");


            //Create Data Adapter
            SqlDataAdapter daSalesReason = new SqlDataAdapter("SELECT * FROM [Sales].[SalesReason]", cnAW);

            //Create data Set

            DataSet ds = new DataSet();
            cnAW.Open();

            daSalesReason.Fill(ds, "SalesReason");
            DataTable dt;
                       

            dt = ds.Tables["SalesReason"];
            //This node is not adding
            //dt.Columns.Add("Age", typeof(string));

            //Read all records from SalesReason table
            foreach (DataColumn dc in dt.Columns)
            {
                /*
                if (dc.ColumnName == "Name")
                {

                    dc.ColumnMapping = MappingType.Element;
                    dc.ExtendedProperties.Add("Age", 50);
                    dc.ColumnMapping = MappingType.Attribute;

                }
                else
                {*/
                    dc.ColumnMapping = MappingType.Element;
                //}
            }

            ds.WriteXml(@"C:\\TechnicalExp\\websites\\MVC-Sites\\SalesReason.xml");
            Console.Write("Completed writing XML file, using a DataSet");
            Console.Read();


            dt.Clear();
            cnAW.Close();


        }
    }
}
