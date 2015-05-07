using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Brug kun til biler, tak.
/// </summary>
public class SqlCarSelect
{
    public string Car_Brand, Car_Model, Car_Fueltype,
        Car_Year, Car_FuelUse, Car_Price, Car_Seats, Car_Doors;

    public SqlCarSelect(string carModel)
    {
        SqlString DatabaseString = new SqlString();
        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());
        SqlCommand DBcommand = new SqlCommand("SELECT * FROM cars WHERE model='" + carModel + "'", DBStr);
        SqlDataReader Reader = DBcommand.ExecuteReader();

        //maerke, braendstofType, model, kmperliter, pris, aargang, saeder, doere
        while (Reader.Read())
        {
            if (Reader["kmperliter"].ToString() != null)
            {
                Car_FuelUse = Reader["kmperliter"].ToString();
            }
            Car_Brand = Reader["maerke"].ToString();
            Car_Model = Reader["model"].ToString();
            Car_Fueltype = Reader["braendstoftype"].ToString();
            Car_Price = Reader["pris"].ToString();
            Car_Year = Reader["aargang"].ToString();
            Car_Seats = Reader["saeder"].ToString();
            Car_Doors = Reader["doere"].ToString();
        }
    }
}