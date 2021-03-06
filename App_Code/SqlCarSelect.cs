﻿using System.Data.SqlClient;

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
        SqlCommand DBcommand = new SqlCommand("select * from cars inner join maerke on maerke.maerkeID = cars.maerke inner join braendstof on braendstof.ID = cars.braendstofType WHERE cars.model='" + carModel + "'", DBStr);
        DBStr.Open();
        SqlDataReader Reader = DBcommand.ExecuteReader();

        //maerkeName, type, model, kmperliter, pris, aargang, saeder, doere
        while (Reader.Read())
        {
            if (Reader["kmperliter"].ToString() != null)
            {
                Car_FuelUse = Reader["kmperliter"].ToString();
            }
            Car_Brand = Reader["maerkeName"].ToString();
            Car_Model = Reader["model"].ToString();
            Car_Fueltype = Reader["type"].ToString();
            Car_Price = Reader["pris"].ToString();
            Car_Year = Reader["aargang"].ToString();
            Car_Seats = Reader["saeder"].ToString();
            Car_Doors = Reader["doere"].ToString();
        }
    }
}